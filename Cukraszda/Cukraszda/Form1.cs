using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Cukraszda
{
    public partial class Form1 : Form
    {
         List<Sutemenyek> sutemeny = new List<Sutemenyek>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sutemenyekToolStripMenuItem.Enabled = false;
        }
        private void toolStripMenuItem1_Fajl_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK==openFileDialog1.ShowDialog())
            {
                using (StreamReader olvas=new StreamReader(openFileDialog1.FileName))
                {
                    while (!olvas.EndOfStream)
                    {
                        Sutemenyek sut = new Sutemenyek(olvas.ReadLine());
                        sutemeny.Add(sut);
                    }
                    olvas.Close();
                    sutemenyekToolStripMenuItem.Enabled = true;
                }
            }
        }

        private void sutemenyekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.form_sutemenyek.Show();
        }

        private void névjegyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.form_nevjegy.Show();
        }
    }
}
