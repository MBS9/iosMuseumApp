# iOS Museum App

This app's software was developed by team lead by Mark Barsi-Siminszky in Britannica International School, Budapest

The content was a collaborative effort between the secondary students of Birtannica and the museums of Budapest.

Software Development collaborators were:
- [Gergely Maros](https://github.com/MarosG07/)
- [Yingtao Zheng](https://github.com/sdsdsdasa)

There is also an [Android only version of this application](https://github.com/MarosG07/museumApp) whose development is lead by Gergely Maros.

This app was made with [.NET MAUI](https://dotnet.microsoft.com/en-us/apps/maui), and hence it can be run on iOS, Android, Windows, and Mac OS. However, it was optimized for mobile, and hence it isn't great on desktop.

## Setup and run locally

1. If running a Mac, please install [XCode](https://developer.apple.com/xcode/).
2. Either:
    a. Install [Visual Studio Community edition or Visual Studio for Mac](https://visualstudio.microsoft.com/). Make sure to install the `.NET MAUI` workload also.
    b. Install [.Net](https://dotnet.microsoft.com/en-us/), and run the command `dotnet workload install maui`.
3. Open the `.sln` file with Visual Studio or `cd` into the directory of your `.sln` if using .NET CLI.
4. Select your target platform (iOS Simulator on MacOS, Android Simulator on Windows), and start the app.

To test on a physical device from the terminal, see the [doumentation](https://learn.microsoft.com/en-us/dotnet/maui/ios/cli?view=net-maui-7.0).

## Add new museum

1. Create the appropriate button, on the appropriate page, and create the appropriate TXT file named after the text on the button. [Here is the code](https://github.com/MBS9/iosMuseumApp/blob/master/shared.cs#L13) by which the TXT file will be selected.
2. Add a main image, name it the same as you did the TXT, just of course the file extension should be `.png`.
3. Inside the TXT file, please add the content using a markdown inspired markup language as follows:

```md
Museum Name
---

# Heading

Content

# Heading 2

## Subheading 1

Content 2

---
# Heading only visible when user clicks "Expand"

Contnet only visible when user clicks "Expand"

# Heading2 only visible when user clicks "Expand"

Contnet2 only visible when user clicks "Expand"

!image.png:Alt text
```

## Publish for iOS

While it can also be published for other platforms, this app was made with iOS in mind primarily.

Run the following to create a `.ipa` on a Mac:
```shell
dotnet publish -f:net7.0-ios -c:Release -p:RuntimeIdentifier=ios-arm64
```

If publishing to the store: `-p:CodesignKey="{fill this out}" -p:CodesignProvision="{fill this out}"`

**Note:** to publish to the App Store, you need to purchase developer program from Apple.

Read more about this in the [documentation](https://learn.microsoft.com/en-us/dotnet/maui/ios/deployment/publish-cli?view=net-maui-7.0).

To create a `CodesignKey` and a `CodesignProvision` [read this documentation](https://learn.microsoft.com/en-us/dotnet/maui/ios/deployment/publish-app-store?view=net-maui-7.0&tabs=vs). You can also use that guide to publish to the App Store.
