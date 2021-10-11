using WhatsAppLink;
using Xunit;

namespace WhatsAppLinkTest
{
    public class WaComposerTest
    {
        [Fact]
        public void GetMobileLinkTest()
        {
            var waComposer = new WaComposer();
            waComposer.WriteText("Pedido",1,1);
            waComposer.WriteText("Item One");

            var textResult = waComposer.GetText();
            
            Assert.Equal("\nPedido\nItem One",textResult);
        }
    }
}