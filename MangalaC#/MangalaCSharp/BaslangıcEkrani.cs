using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MangalaCSharp
{
    public partial class BaslangıcEkrani : Form
    {
        public BaslangıcEkrani()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 ikiOyuncu = new Form1();
            ikiOyuncu.ShowDialog();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 yapayZeka = new Form2();
            yapayZeka.ShowDialog();
        }
    }
}
