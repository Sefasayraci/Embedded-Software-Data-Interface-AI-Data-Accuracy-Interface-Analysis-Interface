using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aerosense
{
    public partial class @abstract : Form
    {
        public @abstract()
        {
            InitializeComponent();
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            contents git = new contents();
            git.Show();
            this.Hide();
        }
    }
}
