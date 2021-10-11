## WhatsAppLink
make custom link to Whatsapp

### Example
```
var waComposer = new WaComposer();
waComposer.WriteText("Pedido",1,1);
waComposer.WriteText("Item One");

var textResult = waComposer.GetText();

var whatsAppLink = WaSender.GetLink("PHONE_NUMBER_HERE",textResult);

```
