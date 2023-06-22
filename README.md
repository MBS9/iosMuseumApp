# iOS Museum App

## Setup and run locally

1. If running a Mac, please install [XCode](https://developer.apple.com/xcode/).
2. Either:
    a. Install [Visual Studio Community edition or Visual Studio for Mac](https://visualstudio.microsoft.com/). Make sure to install the `.NET MAUI` workload also.
    b. Install [.Net](https://dotnet.microsoft.com/en-us/), and run the command `dotnet workload install maui`.
3. Open the `.sln` file with Visual Studio or `cd` into the directory of your `.sln` if using .NET CLI.
4. Select your target platform (iOS Simulator on MacOS, Android Simulator on Windows), and start the app.

To test on a physical device from the terminal, see the [doumentation](https://learn.microsoft.com/en-us/dotnet/maui/ios/cli?view=net-maui-7.0).

## Publish

Run the following to create a `.ipa` on a Mac:
```shell
dotnet publish -f:net7.0-ios -c:Release -p:RuntimeIdentifier=ios-arm64
```

If publishing to the store: `-p:CodesignKey="{fill this out}" -p:CodesignProvision="{fill this out}"`

**Note:** to publish to the App Store, you need to purchase developer program from Apple.

Read more about this in the [documentation](https://learn.microsoft.com/en-us/dotnet/maui/ios/deployment/publish-cli?view=net-maui-7.0).

To create a `CodesignKey` and a `CodesignProvision` [read this documentation](https://learn.microsoft.com/en-us/dotnet/maui/ios/deployment/publish-app-store?view=net-maui-7.0&tabs=vs). You can also use that guide to publish to the App Store.

## Add new museum

1. Create the appropriate button, on the appropriate page, and create the appropriate TXT file named after the text on the button.
   a. [Here is the code](https://github.com/MBS9/iosMuseumApp/blob/master/shared.cs#L13) by which the TXT file will be selected.
2. Add a main image, name it the same as you did the TXT, just of course the file extension should be `.png`.
3. Inside the TXT file, please add the content using a markdown inspired markup language as follows:

```md
Museum Name
---

# Heading

Content

# Heading 2

Content 2

---
# Heading only visible when user clicks "Expand"

Contnet only visible when user clicks "Expand"

# Heading2 only visible when user clicks "Expand"

Contnet2 only visible when user clicks "Expand"

!image.png
```
