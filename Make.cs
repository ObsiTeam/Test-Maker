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
    public partial class Make : Form
    {
        public static String data = null;
        public start()
        {
            InitializeComponent();
        }


        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                button1.Text("Next Question");
                List<string> lines = new List<string>();
                String[] lineas = System.IO.File.ReadAllLines(@"C:\Users\masonrapa\Desktop\" + textBox2.Text + ".txt", Encoding.UTF8);
                foreach (string l in lineas){
                    lines.Add(l);
                }
                data = string.Join(",", lines);
                int n = 0;
            } catch {
                n = n + 1;
                String dato = data.Split(",")[n];
                String correctanswer = dato.Split("[")[0];
                String resto = dato.Split("[")[1];
                foreach (string d in resto.Split(";")){
                    listBox1.Items.Add("");
                }
            }
        }
    }
}
