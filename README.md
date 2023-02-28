![Nuget](https://img.shields.io/nuget/dt/WhatsAppLink)
![Nuget](https://img.shields.io/nuget/v/WhatsAppLink)

# WhatsApp Link Composer

This NuGet package provides a simple and convenient way to create custom links to WhatsApp. With this package, you can easily compose a message in your code and generate a link that, when clicked, will open a chat with a specific phone number and pre-populate the message you composed.

## Installation
To use this package in your project, simply install it via NuGet:

```bash
Install-Package WhatsAppLink
```

## Usage
Here's an example of how you can use this package to compose a message and generate a WhatsApp link:

```csharp
// Create a new instance of the composer
var waComposer = new WaComposer();

// Compose the message
waComposer.WriteText("My Order", 1, 1);
waComposer.WriteText("Item One");

// Get the composed text
var textResult = waComposer.GetText();

// Generate the WhatsApp link
var phoneNumber = "PHONE_NUMBER_HERE";
var whatsAppLink = WaSender.GetLink(phoneNumber, textResult);
```

In the example above, we first create a new instance of WaComposer and use its WriteText method to compose a message. The WriteText method takes two optional parameters: beforeBreak and afterBreak, which specify how many line breaks to add before and after the text. We then call the GetText method to get the composed text.

Next, we use the WaSender.GetLink method to generate a WhatsApp link. This method takes two parameters: the phone number to send the message to, and the composed text. The method returns a string that represents the WhatsApp link.

## Contributing
If you find a bug or have a feature request, please open an issue on the GitHub repository. Pull requests are also welcome!

## License
This project is licensed under the MIT License.
