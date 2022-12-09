using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewKapcha
{
    public class CapchaImages
    {
        public int Id { get; set; }
        public string Link { get; set; }
        public string CapchaText { get; set; }

        public CapchaImages(int id, string link, string text)
        {
            Id = id;
            Link = link ;
            CapchaText = text;
        }
    }

    public static class Core
    {
        public static MainWindow mainWindow;
        public static List<CapchaImages> Capchas = new List<CapchaImages>();
    }
}
