# Apache Lucene.Net

[![Nuget](https://img.shields.io/nuget/dt/Lucene.Net)](https://www.nuget.org/packages/Lucene.Net)
[![Azure DevOps builds (master)](https://img.shields.io/azure-devops/build/lucene-net/6ba240c9-9598-47e7-a793-0ed8a4ba2f8b/3/master)](https://dev.azure.com/lucene-net/Lucene.NET/_build?definitionId=3&_a=summary)
[![GitHub](https://img.shields.io/github/license/NightOwl888/ICU4N)](https://github.com/NightOwl888/ICU4N/blob/master/LICENSE.txt)

## Full-text search for .NET

Apache Lucene.Net is a .NET full-text search engine framework, a C# port of the popular Apache Lucene project.  Apache Lucene.Net is not a complete application, but rather a code library and API that can easily be used to add search capabilities to applications.

The Apache Lucene.Net web site is at:
  http://lucenenet.apache.org

## Supported Frameworks

### Lucene.Net 3.0.3

- .NET Framework 4.0
- .NET Framework 3.5

### Lucene.Net 4.8.0


- [.NET Standard 2.1](https://docs.microsoft.com/en-us/dotnet/standard/net-standard)
- [.NET Standard 2.0](https://docs.microsoft.com/en-us/dotnet/standard/net-standard)
- .NET Framework 4.5

## Status

Latest Stable Version: Lucene.Net 3.0.3

Working toward Lucene.Net 4.8.0 (currently in BETA)

## Download

### Lucene.Net 3.0.3

##### Core Library

[![NuGet version](https://img.shields.io/nuget/v/Lucene.Net.svg)](https://www.nuget.org/packages/Lucene.Net/3.0.3)

```
PM> Install-Package Lucene.Net
```

##### All Packages

- [Lucene.Net](https://www.nuget.org/packages/Lucene.Net/3.0.3) - Core library
- [Lucene.Net.Contrib](https://www.nuget.org/packages/Lucene.Net.Contrib/3.0.3) - Various user contributed functionality and extras
- [Lucene.Net.Contrib.Spatial](https://www.nuget.org/packages/Lucene.Net.Contrib.Spatial/3.0.3) - Geospatial Search
- [Lucene.Net.Contrib.Spatial.NTS](https://www.nuget.org/packages/Lucene.Net.Contrib.Spatial.NTS/3.0.3) - Geospatial search with support for NetTopologySuite.

### Lucene.Net 4.8.0

##### Core Library

[![NuGet version](https://img.shields.io/nuget/vpre/Lucene.Net.svg)](https://www.nuget.org/packages/Lucene.Net/)

```
PM> Install-Package Lucene.Net -Pre
```

##### All Packages

<!--- TO BE ADDED WHEN RELEASED 

- [Lucene.Net.Analysis.Nori](https://www.nuget.org/packages/Lucene.Net.Analysis.Nori/) - Korean Morphological Analyzer

-->

- [Lucene.Net](https://www.nuget.org/packages/Lucene.Net/) - Core library
- [Lucene.Net.Analysis.Common](https://www.nuget.org/packages/Lucene.Net.Analysis.Common/) - Analyzers for indexing content in different languages and domains
- [Lucene.Net.Analysis.Kuromoji](https://www.nuget.org/packages/Lucene.Net.Analysis.Kuromoji/) - Japanese Morphological Analyzer
- [Lucene.Net.Analysis.Morfologik](https://www.nuget.org/packages/Lucene.Net.Analysis.Morfologik/) - Analyzer for dictionary stemming, built-in Polish dictionary
- [Lucene.Net.Analysis.OpenNLP](https://www.nuget.org/packages/Lucene.Net.Analysis.OpenNLP/) - OpenNLP Library Integration
- [Lucene.Net.Analysis.Phonetic](https://www.nuget.org/packages/Lucene.Net.Analysis.Phonetic/) - Analyzer for indexing phonetic signatures (for sounds-alike search)
- [Lucene.Net.Analysis.SmartCn](https://www.nuget.org/packages/Lucene.Net.Analysis.SmartCn/) - Analyzer for indexing Chinese
- [Lucene.Net.Analysis.Stempel](https://www.nuget.org/packages/Lucene.Net.Analysis.Stempel/) - Analyzer for indexing Polish
- [Lucene.Net.Benchmark](https://www.nuget.org/packages/Lucene.Net.Benchmark/) - System for benchmarking Lucene
- [Lucene.Net.Classification](https://www.nuget.org/packages/Lucene.Net.Classification/) - Classification module for Lucene
- [Lucene.Net.Codecs](https://www.nuget.org/packages/Lucene.Net.Codecs/) - Lucene codecs and postings formats
- [Lucene.Net.Expressions](https://www.nuget.org/packages/Lucene.Net.Expressions/) - Dynamically computed values to sort/facet/search on based on a pluggable grammar
- [Lucene.Net.Facet](https://www.nuget.org/packages/Lucene.Net.Facet/) - Faceted indexing and search capabilities
- [Lucene.Net.Grouping](https://www.nuget.org/packages/Lucene.Net.Grouping/) - Collectors for grouping search results
- [Lucene.Net.Highlighter](https://www.nuget.org/packages/Lucene.Net.Highlighter/) - Highlights search keywords in results
- [Lucene.Net.ICU](https://www.nuget.org/packages/Lucene.Net.ICU/) - Specialized ICU (International Components for Unicode) Analyzers and Highlighters
- [Lucene.Net.Join](https://www.nuget.org/packages/Lucene.Net.Join/) - Index-time and Query-time joins for normalized content
- [Lucene.Net.Memory](https://www.nuget.org/packages/Lucene.Net.Memory/) - Single-document in-memory index implementation
- [Lucene.Net.Misc](https://www.nuget.org/packages/Lucene.Net.Misc/) - Index tools and other miscellaneous code
- [Lucene.Net.Queries](https://www.nuget.org/packages/Lucene.Net.Queries/) - Filters and Queries that add to core Lucene
- [Lucene.Net.QueryParser](https://www.nuget.org/packages/Lucene.Net.QueryParser/) - Text to Query parsers and parsing framework
- [Lucene.Net.Replicator](https://www.nuget.org/packages/Lucene.Net.Replicator/)  Files replication utility
- [Lucene.Net.Sandbox](https://www.nuget.org/packages/Lucene.Net.Sandbox/) - Various third party contributions and new ideas
- [Lucene.Net.Spatial](https://www.nuget.org/packages/Lucene.Net.Spatial/) - Geospatial search
- [Lucene.Net.Suggest](https://www.nuget.org/packages/Lucene.Net.Suggest/) - Auto-suggest and Spell-checking support
- [Lucene.Net.TestFramework](https://www.nuget.org/packages/Lucene.Net.TestFramework/) - Framework for testing Lucene-based applications

## Documentation

We now have some preliminary documentation for Lucene.Net 4.8.0 [on the Lucene.Net Website](https://lucenenet.apache.org/).

The API is similar to Java [Lucene 4.8.0](https://lucene.apache.org/core/4_8_0/), which you may also find helpful to review.

> NOTE: We are working on fixing issues with the documentation, but could use more help since it is a massive project. See [#206](https://github.com/apache/lucenenet/pull/206).

### Legacy Versions

- [Lucene.Net 3.0.3 API Documentation](http://incubator.apache.org/lucene.net/docs/3.0.3/Index.html)
- [Lucene.Net 2.9.4 API Documentation](http://incubator.apache.org/lucene.net/docs/2.9.4/Index.html)

## Demos & Tools

There are several demos implemented as simple console applications that can be copied and pasted into Visual Studio or compiled on the command line in the [Lucene.Net.Demo project](https://github.com/apache/lucenenet/tree/master/src/Lucene.Net.Demo).

There is also a dotnet command line tool available on NuGet. It contains all of the demos as well as tools maintaining your Lucene.Net index, featuring operations such as splitting, merging, listing segment info, fixing, deleting segments, upgrading, etc. Always be sure to back up your index before running any commands against it!

- [Prerequisite: .NET Core 3.1.0 Runtime](https://www.microsoft.com/net/download/core#/runtime)

```
dotnet tool install lucene-cli -g --version 4.8.0-beta00007
```

Once installed, you can explore the commands and options that are available by entering the command `lucene`.

[lucene-cli Documentation](https://github.com/apache/lucenenet/blob/master/src/dotnet/tools/lucene-cli/docs/index.md)

## How to Contribute

Lucene.Net is a very large project (over 400,000 executable lines of code and nearly 1,000,000 lines of text total) and we welcome any and all help to maintain such an effort. Read our [Contribution Guide](https://github.com/apache/lucenenet/blob/master/CONTRIBUTING.md) or read on for ways that you can help.

### Join Mailing Lists

[How to Join Mailing Lists](https://cwiki.apache.org/confluence/display/LUCENENET/Mailing+Lists)

### Ask a Question

If you have a general how-to question or need help from the Lucene.Net community, please email the Apache Lucene.Net-User mailing list by sending a message to:

[user@lucenenet.apache.org](mailto:user@lucenenet.apache.org)

We recommend you join the [user mailing list](https://cwiki.apache.org/confluence/display/LUCENENET/Mailing+Lists) to stay looped into all user discussions.

Alternatively, you can get help via [StackOverflow](https://stackoverflow.com/questions/tagged/lucene.net).

Please do not submit general how-to questions to JIRA, use JIRA for bug reports/tasks only.

### Report a Bug

To report a bug, please use the [JIRA issue tracker](https://issues.apache.org/jira/issues/?jql=project%20%3D%20LUCENENET%20AND%20status%20%3D%20Open). You can signup for a JIRA account [here](https://cwiki.apache.org/confluence/signup.action) (it just takes a minute).

### Start a Discussion

To start a development discussion regarding technical features of Lucene.Net, please email the Apache Lucene.Net-Developer mailing list by sending a message to: 

[dev@lucenenet.apache.org](mailto:dev@lucenenet.apache.org)

We recommend you join both the [user and dev mailing lists](https://cwiki.apache.org/confluence/display/LUCENENET/Mailing+Lists) to stay looped in to all user and developer discussions.

### Submit a Pull Request

Before you start working on a pull request, please read our [Contributing](https://github.com/apache/lucenenet/blob/master/CONTRIBUTING.md) guide.

If you plan to submit multiple pull requests, please submit an [Individual Contributor License](https://cwiki.apache.org/confluence/display/LUCENENET/Individual+Contributor+License), or for individual pull requests, just submit the request and in the description state that the code is your original work and you license it under the [Apache License v2](http://www.apache.org/licenses/LICENSE-2.0).

## Building and Testing

### Command Line

Building on the Command Line is currently only supported on Windows.

##### Prerequisites

1. [Powershell](https://msdn.microsoft.com/en-us/powershell/scripting/setup/installing-windows-powershell) 3.0 or higher (see [this question](http://stackoverflow.com/questions/1825585/determine-installed-powershell-version) to check your Powershell version)
2. [.NET Core SDK 3.1 or higher](https://dotnet.microsoft.com/download/visual-studio-sdks)
3. [.NET Framework 4.8 Developer Pack](https://dotnet.microsoft.com/download/visual-studio-sdks)

##### Execution

To build the source, clone or download and unzip the repository. From the repository root, execute:

```
> build [options]
```

##### Build Options

<table>
    <tr>
        <th>Short</th>
        <th>Long</th>
        <th>Description</th>
        <th>Example</th>
    </tr>
    <tr>
        <td>&#8209;config</td>
        <td>&#8209;&#8209;Configuration</td>
        <td>The build configuration ("Release" or "Debug").</td>
        <td>build&nbsp;&#8209;&#8209;Configuration:Debug</td>
    </tr>
    <tr>
        <td>&#8209;mp</td>
        <td>&#8209;&#8209;MaximumParallelJobs</td>
        <td>The maximum number of parallel jobs to run during testing. If not supplied, the default is 8.</td>
        <td>build&nbsp;&#8209;t&nbsp;&#8209;mp:10</td>
    </tr>
    <tr>
        <td>&#8209;pv</td>
        <td>&#8209;&#8209;PackageVersion</td>
        <td>The NuGet package version. If not supplied, will use the version from the Version.proj file.</td>
        <td>build&nbsp;&#8209;pv:4.8.0&#8209;beta00001</td>
    </tr>
    <tr>
        <td>&#8209;t</td>
        <td>&#8209;&#8209;Test</td>
        <td>Runs the tests after building. Note that testing typically takes around 40 minutes with 8 parallel jobs.</td>
        <td>build&nbsp;&#8209;t</td>
    </tr>
    <tr>
        <td>&#8209;v</td>
        <td>&#8209;&#8209;Version</td>
        <td>The assembly file version. If not supplied, will use the PackageVersion (excluding any pre-release tag).</td>
        <td>build&nbsp;&#8209;pv:4.8.0&#8209;beta00001&nbsp;&#8209;v:4.8.0</td>
    </tr>
</table>

NuGet packages are output by the build to the `/release/NuGetPackages/` directory. Test results (if applicable) are output to the `/release/TestResults/` directory.

You can setup Visual Studio to read the NuGet packages like any NuGet feed by following these steps:

1. In Visual Studio, right-click the solution in Solution Explorer, and choose "Manage NuGet Packages for Solution"
2. Click the gear icon next to the Package sources dropdown.
3. Click the `+` icon (for add)
4. Give the source a name such as `Lucene.Net Local Packages`
5. Click the `...` button next to the Source field, and choose the `/src/release/NuGetPackages` folder on your local system.
6. Click Ok

Then all you need to do is choose the `Lucene.Net Local Packages` feed from the dropdown (in the NuGet Package Manager) and you can search for, install, and update the NuGet packages just as you can with any Internet-based feed.

### Visual Studio

#### Prerequisites

1. Visual Studio 2019 or higher
2. [.NET Core SDK 3.1 or higher](https://dotnet.microsoft.com/download/visual-studio-sdks)
3. [.NET Framework 4.8 Developer Pack](https://dotnet.microsoft.com/download/visual-studio-sdks)

#### Execution

1. Open `Lucene.Net.sln` in Visual Studio.
2. Choose the target framework to test by opening `build/TestTargetFramework.proj` and uncommenting the corresponding `<TargetFramework>`.
3. Build a project or the entire solution, and wait for Visual Studio to discover the tests - this may take several minutes.
4. Run or debug the tests in Test Explorer, optionally using the desired filters.

> **NOTE:** When running tests in Visual Studio, be sure to [set the default processor architecture to 64 bit](https://stackoverflow.com/a/45946727) to avoid running out of virtual memory on some tests.

### Azure DevOps

We have setup our `azure-pipelines.yml` file with logical defaults so anyone with an Azure DevOps account can build Lucene.Net and run the tests with minimal effort. Even a free Azure DevOps account will work, but tests will run much faster if the account is setup as public, which enables up to 10 parallel jobs to run simultaneously.

#### Prerequisites

1. An [Azure DevOps](https://azure.microsoft.com/en-us/services/devops/) account.
2. A fork of this repository either on GitHub or Azure DevOps. The rest of these instructions assume a [GitHub fork](https://help.github.com/en/github/getting-started-with-github/fork-a-repo).

#### Execution

##### If you don't already have a pipeline set up:

1. [Create an Azure DevOps organization](https://docs.microsoft.com/en-us/azure/devops/organizations/accounts/create-organization?view=azure-devops). If you already have one that you wish to use, you may skip this step.
2. [Create an Azure DevOps project](https://docs.microsoft.com/en-us/azure/devops/organizations/projects/create-project?view=azure-devops&tabs=preview-page). We recommend naming the project Lucene.NET. Note that if you are using a free Azure DevOps account, you should choose to make the project public in order to enable 10 parallel jobs. If you make the project private, you will only get 1 parallel job. Also, if disabling features, make sure to leave Pipelines enabled.
3. Create an Azure DevOps pipeline.
   - Click on "Pipelines" from the left menu.
   - Click the "Create Pipeline" or "New Pipeline" button, depending on whether any pipelines already exist.
   - Select GitHub as the location to find the YAML file.
   - Select the fork of this repository you created in "Prerequisites". Note that if this is a new Azure DevOps account you may need to [setup extra permissions to access your GitHub account](https://docs.microsoft.com/en-us/azure/devops/pipelines/repos/github?view=azure-devops&tabs=yaml).
   - Next a "Review your YAML" page is presented showing the contents of `azure-pipelines.yml`. There is documentation near the top of the file indicating the varaibles that can be setup to enable additional options, but note that the default configuration will automatically run the build and all of the tests.
   - Click the "Run" button at the top right of the page.

##### If you already have a pipeline set up:

1. Click on "Pipelines" from the left menu.
2. Select the pipeline you wish to run.
3. Click the "Queue" button on the upper right.
4. (Optional) Select the branch and override any variables in the pipeline for this run.
5. Click the "Run" button.

Note that after the build is complete, the `nuget` artifact contains `.nupkg` files which may be downloaded to your local machine where you can [setup a local folder to act as a NuGet feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds).

> It is also possible to add an Azure DevOps feed id to a new variable named `ArtifactFeedID`, but we are getting mixed results due to permission issues.
