using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticari_Otomasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        form_urunler form_Urunler;
        form_musteriler form_musteriler;
        private void URUNLER_BUTTON_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (form_Urunler==null)
            {
                form_Urunler = new form_urunler();
                form_Urunler.MdiParent = this;
                form_Urunler.Show();
            }
            
        }

        private void MUSTERI_BUTTON_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (form_musteriler == null)
            {
                form_musteriler = new form_musteriler();
                form_musteriler.MdiParent = this;
                form_musteriler.Show();
            }
        }
    }
}
