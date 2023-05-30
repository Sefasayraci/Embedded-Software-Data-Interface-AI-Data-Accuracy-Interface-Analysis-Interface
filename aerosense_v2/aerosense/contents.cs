using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace aerosense
{
    public partial class contents : Form
    {
        public contents()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                telemetry git = new telemetry();
                git.Show();
                this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
                @abstract git = new @abstract();
                git.Show();
                this.Hide();
        }
    }
}
