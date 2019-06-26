using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventosDelegate
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnCriarButtonEmRumTime_Click(object sender, EventArgs e)
        {
            var btn = new Button();
            btn.Parent = this;
            this.Contains(btn);
            btn.Text = "Click aqui";
            btn.Size = new Size(width: 75, height: 23);
            btn.Location = new Point(x: 12, y: 40);
            btn.Click += new EventHandler(Btn_Click); //apontando um evento para um método
            btn.Click += delegate (object s, EventArgs eventArgs)
            {
                //Metodo Anônimo
                MessageBox.Show("Test");
            };
            btn.Click += (s, eventArrs) => MessageBox.Show("Hello");
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ola mundo");
        }
    }
}
