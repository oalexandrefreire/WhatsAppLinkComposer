using WhatsAppLink;
using Xunit;

namespace WhatsAppLinkTest
{
    public class WaFormatTest
    {
        [Fact]
        public void FormatBold()
        {
            var result = WaFormat.Bold("text");
            Assert.Equal(" *text* ",result);
        }
        
        [Fact]
        public void FormatItalic()
        {
            var result = WaFormat.Italic("text");
            Assert.Equal(" _text_ ",result);
        }
        
        [Fact]
        public void FormatMonospace()
        {
            var result = WaFormat.Monospace("text");
            Assert.Equal(" ```text``` ",result);
        }
   
        [Fact]
        public void FormatStrikethrough()
        {
            var result = WaFormat.Strikethrough("text");
            Assert.Equal(" ~text~ ",result);
        }
    }
}