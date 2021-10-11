using System;

namespace WhatsAppLink
{
    public class WaComposer
    {
        private string Text = "";

        public void WriteText(string text = "", int lineBreakBefore = 0, int lineBreakAfter = 0)
        {
            var lbAfter = "";
            var lbBefore = "";
            for (var i = 0; lineBreakAfter > i; i++){
                lbAfter += "\n";
            }
            for (var i = 0; lineBreakBefore > i; i++){
                lbBefore += "\n";
            }
            this.Text += (!String.IsNullOrEmpty(lbBefore) ? lbBefore : "") + (!String.IsNullOrEmpty(text) ? text : "") + (!String.IsNullOrEmpty(lbAfter) ? lbAfter : "");
        }

        public string GetText(){
            return this.Text;
        }
    }
}
