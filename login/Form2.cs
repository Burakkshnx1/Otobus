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

namespace login
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void altoButton1_Click(object sender, EventArgs e)
        {
            if (altoButton1.Text == "")
            {
                MessageBox.Show("Bu alan boş bırakılamaz", "Gufo");
            }
            else
            {
                MessageBox.Show(altoTextBox1.Text+"adresine, hesabına yeniden girebilmeni sağlayacak bir bağlantı içeren bir e-posta gönderdik.", "Gufo");
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
        }
    }
}
