namespace WhatsAppLink
{
    //https://faq.whatsapp.com/general/chats/how-to-format-your-messages/
    public static class WaFormat
    {
        public static string Italic(string text)
        {
            return $" _{RemoveSpace(text)}_ ";
        }

        public static string Bold(string text)
        {
            return $" *{RemoveSpace(text)}* ";
        }
        
        public static string Strikethrough(string text)
        {
            return $" ~{RemoveSpace(text)}~ ";
        }    
        
        public static string Monospace(string text)
        {
            return $" ```{RemoveSpace(text)}``` ";
        }

        private static string RemoveSpace(string text)
        {
            return text.Trim();
        }
        
    }
}