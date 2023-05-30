using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


// Şifre ile arayüz girilecek.
//


namespace aerosense
{
    public partial class password : Form
    {
        public password()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="sefasayraci" && textBox2.Text=="232045")
            {
                textBox1.Text = "sefasayraci";
               // telemetry git = new telemetry();
                contents git = new contents();
                git.Show();
                this.Hide();

            }
            //catch(Exception ex)
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Parola Hatası", "ERROR");
            }

        }
    }
}
