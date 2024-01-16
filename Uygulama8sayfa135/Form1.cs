using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama8sayfa135
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }
        byte[,] dizi = new byte[4, 4];
        private void btnYeni_Click(object sender, EventArgs e)
        {
            Random rastgere = new Random();
            int satirRastgere = rastgere.Next(4);
            int sutunRastgere = rastgere .Next(4);
            dizi[satirRastgere, sutunRastgere] = 1;
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            byte satir=byte.Parse(txtSatir.Text);
            byte sutun = byte.Parse(txtSutun.Text);
            PictureBox kutu = this.Controls.Find("p"+satir + sutun, true)[0] as PictureBox;
            byte durum = dizi[satir, sutun];
            if (durum == 0)
            { 
             kutu.BackColor = Color.Green; 
            }
            else
            { 
             kutu.BackColor = Color.Red; 
            }
            SerializableAttribute serializable = new SerializableAttribute();
        }
    }
}
