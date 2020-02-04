using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjeOrijinal
{
    public partial class FormOdeme : Form
    {
        public FormOdeme()
        {
            InitializeComponent();
        }
      
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void FormOdeme_Load(object sender, EventArgs e)
        {

            FormSiparis frmsiparis = (FormSiparis)Application.OpenForms["FormSiparis"];

            for (int i=0;i<frmsiparis.lwSepet.Items.Count;i++)
            {
                lwOdeme.Items.Add((ListViewItem)frmsiparis.lwSepet.SelectedItems[i].Clone());
            }
           
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            for(int i=0;i<lwOdeme.Items.Count;i++)
            {
                toplam += Convert.ToInt32(lwOdeme.Items[i].SubItems[12].Text);
            }
            label2.Text = toplam.ToString();
        }
    }
}
