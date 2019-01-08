using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Ploy.MyClasses;

namespace Ploy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<DortgenKutu> dK = new List<DortgenKutu>();
        private void Form1_Load(object sender, EventArgs e)
        {
            DortgenKutu kutu = new DortgenKutu();
            kutu.Id = 1;
            kutu.UrunAd = "Karton Kutu";
            kutu.KisaKenar = 10;
            kutu.UzunKenar = 15;
            kutu.Yukseklik = 20;
            dK.Add(kutu);
            kutu = new DortgenKutu();
            kutu.Id = 2;     
            kutu.UrunAd = "Mukavva Kutu";
            kutu.KisaKenar = 15;
            kutu.UzunKenar = 10;
            kutu.Yukseklik = 25;
            dK.Add(kutu);
            kutu = new DortgenKutu();
            kutu.Id = 3;
            kutu.UrunAd = "Karton Kutu";
            kutu.KisaKenar = 17;
            kutu.UzunKenar = 17;
            kutu.Yukseklik = 27;
            dK.Add(kutu);
            kutu = new DortgenKutu();
            kutu.Id = 4;
            kutu.UrunAd = "Karton Kutu";
            kutu.KisaKenar = 18;
            kutu.UzunKenar = 30;
            kutu.Yukseklik = 28;
            dK.Add(kutu);

            dataGridView1.DataSource = dK;
        }
    }
}
