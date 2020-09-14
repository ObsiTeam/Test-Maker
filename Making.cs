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
    public partial class Making : Form
    {
        public static int n = 0;
        public static String correct = null;
        public static List<string> answ = new List<string>();
        public Making(){
            InitializeComponent();
        }

        private void button1_Click_2(object sender, EventArgs e)
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

        private void button3_Click_1(object sender, EventArgs e)
        {
            try {
                List<string> lines = new List<string>();
                String[] lineas = System.IO.File.ReadAllLines(@""+textBox2.Text+ ".code");
                label2.Text = "Test maker by @masonrapa";
                textBox1.Text = "";
                button3.Text = "Next Question";
                listBox1.Items.Clear();
                String data = lineas[0];
                List<string> dato = new List<string>(data.Split(new string[] { "," }, StringSplitOptions.None));
                n = n + 1;
                try {
                    String datx = dato[n];
                    List<string> divi = new List<string>(datx.Split(new string[] { "[" }, StringSplitOptions.None));
                    correct = divi[0];
                    List<string> before = new List<string>(correct.Split(new string[] { "^" }, StringSplitOptions.None));
                    String pregunta = before[0];
                    textBox3.Text = pregunta;
                    correct = before[1];
                    String preguntas = divi[1];
                    List<string> questions = new List<string>(preguntas.Split(new string[] { ";" }, StringSplitOptions.None));
                    foreach (string q in questions) {
                        listBox1.Items.Add(q.Replace("]", ""));
                    }
                } catch {
                    Console.WriteLine("Final");
                    int mcou = 0;
                    int lcou = 0;
                    for (int i = 0; i < answ.Count; i++) {
                        listBox1.Items.Add("Question: "+(i+1)+": " + answ[i].Replace("+", "Correct!").Replace("-", "Wrong!"));
                        if (answ[i] == "+") {
                            mcou = mcou + 1;
                        } else if (answ[i] == "-") {
                            lcou = lcou + 1;
                        }
                    }
                    int mas = (mcou * 100) / answ.Count;
                    int menos = (lcou * 100) / answ.Count;
                    listBox1.Items.Add("");
                    listBox1.Items.Add("Correct: "+mas+"%");
                    listBox1.Items.Add("Wrong: "+menos+"%");
                }
            } catch {
                label2.Text = "This test name doesn't exist!";
            }
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (textBox1.Text != "Correct!" && textBox1.Text != "Wrong!")
            {
                if (correct.Contains(listBox1.SelectedIndex.ToString()))
                {
                    textBox1.Text = "Correct!";
                    textBox1.BackColor = Color.FromArgb(0, 255, 0);
                    answ.Add("+");
                }
                else
                {
                    textBox1.Text = "Wrong!";
                    textBox1.BackColor = Color.FromArgb(255, 0, 0);
                    answ.Add("-");
                }
            }
        }
    }
}
