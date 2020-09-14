using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testmaker
{
    public partial class Create : Form
    {
        public static String correct = null;
        public Create()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            List<string> textos = new List<string>();
            textos.Add(textBox1.Text);
            textos.Add(textBox2.Text);
            textos.Add(textBox3.Text);
            textos.Add(textBox4.Text);
            correct = null;
            for (int i = 0; i < checkedListBox1.CheckedIndices.Count; i++){
                correct = correct + checkedListBox1.CheckedIndices[i];
            }
            String raw = textBox6.Text+"^"+correct + "[" + textBox1.Text + ";" + textBox2.Text + ";" + textBox3.Text + ";" + textBox4.Text + "]";
            List<string> lines = new List<string>();
            try{
                String[] lineas = System.IO.File.ReadAllLines(@""+textBox5.Text + ".code", Encoding.UTF8);
                foreach (string l in lineas) {
                    lines.Add(l);
                }
            }catch { }
            string result = string.Join(",", lines);
            System.IO.File.WriteAllText(@""+textBox5.Text + ".code", result + "," + raw + Environment.NewLine);
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox6.Text = "";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            int nj = this.Controls.Count;
            for (int j = 0; j < nj; j++){
                this.Controls.RemoveAt(0);
            }
            Form fh = new Form0() as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.Controls.Add(fh);
            this.Tag = fh;
            fh.Show();
        }
    }
}
