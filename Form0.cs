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
    public partial class Form0 : Form
    {
        public Form0()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int nj = this.Contenedor.Controls.Count;
            for (int j = 0; j < nj; j++)
            {
                this.Contenedor.Controls.RemoveAt(0);
            }
            Form fh = new Create() as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.Contenedor.Controls.Add(fh);
            this.Contenedor.Tag = fh;
            fh.Show();
        }

        private void button1_Click(object sender, EventArgs e){
            int nj = this.Contenedor.Controls.Count;
            for (int j = 0; j < nj; j++){
                this.Contenedor.Controls.RemoveAt(0);
            }
            Form fh = new Create() as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.Contenedor.Controls.Add(fh);
            this.Contenedor.Tag = fh;
            fh.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            int nj = this.Contenedor.Controls.Count;
            for (int j = 0; j < nj; j++){
                this.Contenedor.Controls.RemoveAt(0);
            }
            Form fh = new Making() as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.Contenedor.Controls.Add(fh);
            this.Contenedor.Tag = fh;
            fh.Show();
        }
    }
}
