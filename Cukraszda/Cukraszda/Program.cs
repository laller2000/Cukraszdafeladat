using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cukraszda
{
    static class Program
    {
        public static Form form_nevjegy = null;
        public static Form form_sutemenyek = null;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            form_nevjegy = new Form_Nevjegy();
            form_sutemenyek = new Form_Sutemenyek();
            Application.Run(new Form1());
        }
    }
}
