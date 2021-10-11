using WhatsAppLink;
using Xunit;

namespace WhatsAppLinkTest
{
    public class WaSenderTest
    {
        [Fact]
        public void GetMobileLinkTest()
        {
            var link = WaSender.GetLink("123","ola",true);
            Assert.Equal("whatsapp://send?text=ola&phone=123",link);
        }
        
        [Fact]
        public void GetWebLinkTest()
        {
            var link = WaSender.GetLink("123","ola");
            Assert.Equal("https://wa.me/123?text=ola",link);
        }


    }
}
