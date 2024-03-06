using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2.unite_28_uygulam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int dongu = 1;
            int toplam = 0;
            while(toplam <= 1000)
            {
                toplam += dongu;
                dongu += 1;

            }
            MessageBox.Show(dongu.ToString());
        }
    }
}
