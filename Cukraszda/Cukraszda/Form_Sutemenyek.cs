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
    public partial class Form_Sutemenyek : Form
    {
        List<Sutemenyek> sutemeny = new List<Sutemenyek>();
        List<string> rendeles = new List<string>();
        List<int> darab = new List<int>();
        public string szamlatker;
        public Form_Sutemenyek()
        {
            InitializeComponent();
        }

        private void Form_Sutemenyek_Load(object sender, EventArgs e)
        {
            using (StreamReader olvas =new StreamReader("sutemenyek.txt"))
            {
                while (!olvas.EndOfStream)
                {
                    Sutemenyek stu = new Sutemenyek(olvas.ReadLine());
                    sutemeny.Add(stu);
                }
                olvas.Close();
            }
            for (int i = 0; i < sutemeny.Count; i++)
            {
                checkBox1_Sut1.Text = sutemeny[0].Nev + (sutemeny[0].Ar+"Ft");
                checkBox2_Sut2.Text = sutemeny[1].Nev + (sutemeny[1].Ar+"Ft");
                checkBox3_Sut3.Text = sutemeny[2].Nev + (sutemeny[2].Ar+"Ft");
                checkBox4_Sut4.Text = sutemeny[3].Nev + (sutemeny[3].Ar+"Ft");
                checkBox5_Sut5.Text = sutemeny[4].Nev + (sutemeny[4].Ar+"Ft");
            }
        }

        private void button1_Rendel_MouseClick(object sender, MouseEventArgs e)
        {
            
            if (e.Button==System.Windows.Forms.MouseButtons.Left)
            {
                if (checkBox1_Sut1.Checked)
                {
                    rendeles.Add(checkBox1_Sut1.Text);
                    darab.Add(Convert.ToInt32(textBox1_adag1.Text));
                    
                }
                else if (checkBox2_Sut2.Checked)
                {
                    rendeles.Add(checkBox2_Sut2.Text);
                    darab.Add(Convert.ToInt32(textBox2_adag2.Text));
                }
                else if (checkBox3_Sut3.Checked)
                {
                    rendeles.Add(checkBox3_Sut3.Text);
                    darab.Add(Convert.ToInt32(textBox3_Adag3.Text));
                }
                else if (checkBox4_Sut4.Checked)
                {
                    rendeles.Add(checkBox4_Sut4.Text);
                    darab.Add(Convert.ToInt32(textBox4_adag4.Text));
                }
                else if (checkBox5_Sut5.Checked)
                {
                    rendeles.Add(checkBox5_Sut5.Text);
                    darab.Add(Convert.ToInt32(textBox5_adag5.Text));
                }
                else
                {
                    MessageBox.Show("Rendeljen valamit!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Form formrendel = new Form();
                RichTextBox rendelesadatok = new RichTextBox();
                formrendel.Controls.Add(rendelesadatok);
                for (int i = 0; i < rendeles.Count; i++)
                {
                    for (int j = 0; j < darab.Count; j++)
                    {
                        rendelesadatok.Text = rendeles[i] + " " + darab[j];
                    }
                }
                formrendel.Show();
            }
        }
    }
}
