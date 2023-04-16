# iOS Museum App

## Setup and run locally

1. If running a Mac, please install [XCode](https://developer.apple.com/xcode/).
2. Install [Visual Studio Community edition or Visual Studio for Mac](https://visualstudio.microsoft.com/). Make sure to install the `.NET MAUI` workload also.
3. Open the `.sln` file with Visual Studio.
4. Select your target platform (iOS on MacOS, Android on Windows), and start the app.

## Publish

Run the following to create a `.ipa` on a Mac:
```shell
dotnet publish -f:net7.0-ios -c:Release -p:RuntimeIdentifier=ios-arm64
```

Optionally: `-p:CodesignKey="{fill this out}" -p:CodesignProvision="{fill this out}"`

Read more about this in the [documentation](https://learn.microsoft.com/en-us/dotnet/maui/ios/deployment/publish-cli?view=net-maui-7.0).

To create a `CodesignKey` and a `CodesignProvision` [read this documentation](https://learn.microsoft.com/en-us/dotnet/maui/ios/deployment/publish-app-store?view=net-maui-7.0&tabs=vs). You can also use that guide to publish to the App Store.
