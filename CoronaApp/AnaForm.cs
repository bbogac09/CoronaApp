using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoronaApp
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void yardımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YardimForm form = new YardimForm();
            form.Show();
        }
    }
}
