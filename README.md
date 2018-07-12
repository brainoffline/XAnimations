# XAnimations

XAnimations gives Xamarin developers some helpful animations which they can use for Xamarin Native, and Xamarin.Forms

[![Twitter chat](https://twitter.com/brainoffline)](https://twitter.com/brainoffline)

## Build Status

| Build Server | Type  | Platform | Status  |
|--------------|-------|----------|---------|
|              |       |          |         |
|              | Tests |          |         |

## Installation
XAnimations is available in two varieties:
* XAnimations for Xamarin Native NuGet Official Releases: [![NuGet](https://img.shields.io/nuget/vpre/Xanimations.svg?label=NuGet)](https://www.nuget.org/packages/Xanimations)
* XAnimation.Forms NuGet Official Releases: [![NuGet](https://img.shields.io/nuget/vpre/Xanimation.Forms.svg?label=NuGet)](https://www.nuget.org/packages/Xanimation.Forms)

## Documentation

Browse our [full documentation for XAnimation](https://github.com/brainoffline/XAnimations/wiki).

## Supported Platforms
XAnimations is focused on the following platforms:
 - iOS (11+ is the latest supported major version)
 - Android (6.0+/SDK 25/Marshmallow is the oldest supported version)
 - UWP (Fall Creators Update+)

## Current Animations:
The following Animations are available in XAnimations Native:

The following Animations are available in XAnimation.Forms:
 
## Contributing
Please read through our [Contribution Guide](CONTRIBUTING.md). We are not accepting new PRs for full features, however any issue that is marked as `up for grabs` are open for community contributions. We encourage creating new issues for bugs found during usage that the team will triage. Additionally, we are open for code refactoring suggestions in PRs.

## Building XAnimations and XAnimation.Forms
If building on Visual Studio 2017 you will need the following SDKs and workloads installed:

### Workloads need:
- Xamarin
- .NET Core
- UWP

### You will need the following SDKs
- Android 8.1 SDK Installed
- UWP 10.0.16299 SDK Installed

To build through the command line, navigate to where XAnimations.sln file exists then run:

```csharp
dotnet restore
msbuild XAnimations.sln
```

## FAQ
The Xanimations frequently asked questions can be found in the [FAQ on our Wiki](https://github.com/BrainOffline/XAnimations/wiki#faq).

## License
Please see the [License](LICENSE).
