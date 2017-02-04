﻿using Lucene.Net.Support;
using System;
using System.Diagnostics.CodeAnalysis;

namespace Lucene.Net.Analysis.Util
{
    /*
	 * Licensed to the Apache Software Foundation (ASF) under one or more
	 * contributor license agreements.  See the NOTICE file distributed with
	 * this work for additional information regarding copyright ownership.
	 * The ASF licenses this file to You under the Apache License, Version 2.0
	 * (the "License"); you may not use this file except in compliance with
	 * the License.  You may obtain a copy of the License at
	 *
	 *     http://www.apache.org/licenses/LICENSE-2.0
	 *
	 * Unless required by applicable law or agreed to in writing, software
	 * distributed under the License is distributed on an "AS IS" BASIS,
	 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
	 * See the License for the specific language governing permissions and
	 * limitations under the License.
	 */

    /// <summary>
    /// A StringBuilder that allows one to access the array.
    /// </summary>
    public class OpenStringBuilder : ICharSequence
    {
        protected char[] m_buf;
        protected int m_len;

        public OpenStringBuilder() 
            : this(32)
        {
        }

        public OpenStringBuilder(int size)
        {
            m_buf = new char[size];
        }

        public OpenStringBuilder(char[] arr, int len)
        {
            Set(arr, len);
        }

        public virtual int Length
        {
            set
            {
                this.m_len = value;
            }
            get { return m_len; }
        }

        public virtual void Set(char[] arr, int end)
        {
            this.m_buf = arr;
            this.m_len = end;
        }

        [WritableArray]
        [SuppressMessage("Microsoft.Performance", "CA1819", Justification = "Lucene's design requires some writable array properties")]
        public virtual char[] Array
        {
            get
            {
                return m_buf;
            }
        }

        // LUCENENE NOTE: This is essentially a duplicate of Length (except that property can be set).
        // .NET uses Length for StringBuilder anyway, so that property is preferable to this one.
        //public virtual int Count // LUCENENET NOTE: This was size() in Lucene.
        //{
        //    get{ return m_len; }
        //}

        public virtual int Capacity
        {
            get { return m_buf.Length; }
        }

        public virtual OpenStringBuilder Append(string csq) // LUCENENET TODO: Add overloads for ICharSequence and StringBuilder
        {
            return Append(csq, 0, csq.Length);
        }

        public virtual OpenStringBuilder Append(string csq, int start, int end) // LUCENENET TODO: Add overloads for ICharSequence and StringBuilder
        {
            Reserve(end - start);
            for (int i = start; i < end; i++)
            {
                UnsafeWrite(csq[i]);
            }
            return this;
        }

        public virtual OpenStringBuilder Append(char c)
        {
            Write(c);
            return this;
        }

        public virtual char CharAt(int index) // LUCENENET TODO: Remove (replaced with this[])
        {
            return m_buf[index];
        }

        public virtual void SetCharAt(int index, char ch) // LUCENENET TODO: Remove (replaced with this[])
        {
            m_buf[index] = ch;
        }

        // LUCENENET specific - added to .NETify
        public virtual char this[int index]
        {
            get { return m_buf[index]; }
            set { m_buf[index] = value; }
        }

        public virtual ICharSequence SubSequence(int start, int end)
        {
            throw new System.NotSupportedException(); // todo
        }

        public virtual void UnsafeWrite(char b)
        {
            m_buf[m_len++] = b;
        }

        public virtual void UnsafeWrite(int b)
        {
            UnsafeWrite((char)b);
        }

        public virtual void UnsafeWrite(char[] b, int off, int len)
        {
            System.Array.Copy(b, off, m_buf, this.m_len, len);
            this.m_len += len;
        }

        protected virtual void Resize(int len)
        {
            char[] newbuf = new char[Math.Max(m_buf.Length << 1, len)];
            System.Array.Copy(m_buf, 0, newbuf, 0, Length);
            m_buf = newbuf;
        }

        public virtual void Reserve(int num)
        {
            if (m_len + num > m_buf.Length)
            {
                Resize(m_len + num);
            }
        }

        public virtual void Write(char b)
        {
            if (m_len >= m_buf.Length)
            {
                Resize(m_len + 1);
            }
            UnsafeWrite(b);
        }

        public virtual void Write(int b)
        {
            Write((char)b);
        }

        public void Write(char[] b)
        {
            Write(b, 0, b.Length);
        }

        public virtual void Write(char[] b, int off, int len)
        {
            Reserve(len);
            UnsafeWrite(b, off, len);
        }

        public void Write(OpenStringBuilder arr) // LUCENENET TODO: Add overload for StringBuilder
        {
            Write(arr.m_buf, 0, m_len);
        }

        public virtual void Write(string s)
        {
            Reserve(s.Length);
            s.CopyTo(0, m_buf, m_len, s.Length - 0);
            m_len += s.Length;
        }

        public virtual void Flush()
        {
        }

        public void Reset()
        {
            m_len = 0;
        }

        public virtual char[] ToCharArray()
        {
            char[] newbuf = new char[Length];
            System.Array.Copy(m_buf, 0, newbuf, 0, Length);
            return newbuf;
        }

        public override string ToString()
        {
            return new string(m_buf, 0, Length);
        }
    }
}