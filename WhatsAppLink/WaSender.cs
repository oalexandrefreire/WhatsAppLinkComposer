using System.Web;

namespace WhatsAppLink
{
    public static class WaSender
    {
        public static string GetLink(string phone, string text, bool isMobileLink = false)
        {
            if(isMobileLink)
                return "whatsapp://send?text=" + HttpUtility.UrlEncode(text) + "&phone=" + phone;
            
            return "https://wa.me/"+ phone +"?text=" + HttpUtility.UrlEncode(text);
        }
    }
}