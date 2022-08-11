using Businesss;
using DTO.Concrete;
using Entitys.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Veritabani.TablolarRepo;
using Entity.Models;
namespace KutuphaneOtomasyon
{
    public partial class Grafik : Form
    {
        public Grafik()
        {
            InitializeComponent();
        }
		//müsait kitaplar, tüm kitaplar ve zimmetli kitapları bulması için yazdığım metotları çağırıp saydırıp sayı olarak atadım ve bu atamaları grafikte kullandım.
        private void Grafik_Load(object sender, EventArgs e)
        {
			double[] x = { 1, 2, 3 };
			int countAlinabilir = Tablolar.Kitaplar.GetAvailableKitap().Count;
			int countTum = Tablolar.Kitaplar.GetList().ToList().Count;
			int countZimmetli = Tablolar.Kitaplar.GetAllZimmetliKitaplar().Count;
			double[] y = { countAlinabilir };
			double[] y1 = { countZimmetli };
			double[] y2 = { countTum };
			zedGraphControl1.GraphPane.CurveList.Clear();
			zedGraphControl1.GraphPane.AddBar("Alınabilir", x, y, Color.Green);
			zedGraphControl1.GraphPane.AddBar("Zimmetli", x, y1, Color.Red);
			zedGraphControl1.GraphPane.AddBar("Hepsi", x, y2, Color.Yellow);
			zedGraphControl1.GraphPane.Title.Text = "Kitap Grafik";
			zedGraphControl1.GraphPane.XAxis.Title.Text = "Durum";
			zedGraphControl1.GraphPane.YAxis.Title.Text = "Kitap Sayısı";
			zedGraphControl1.GraphPane.Border.IsVisible = false;
			zedGraphControl1.GraphPane.XAxis.ResetAutoScale(zedGraphControl1.GraphPane, CreateGraphics());
			zedGraphControl1.GraphPane.YAxis.ResetAutoScale(zedGraphControl1.GraphPane, CreateGraphics());
			zedGraphControl1.Refresh();
		}
    }
}