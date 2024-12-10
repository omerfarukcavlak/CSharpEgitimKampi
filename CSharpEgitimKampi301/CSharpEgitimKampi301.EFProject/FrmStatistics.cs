using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.EFProject
{
    public partial class FrmStatistics : Form
    {
        public FrmStatistics()
        {
            InitializeComponent();
        }
        EgitimKampiEfTraveDbEntities db = new EgitimKampiEfTraveDbEntities();
        private void FrmStatistics_Load(object sender, EventArgs e)
        {
            lblLocationCount.Text = db.Location.Count().ToString();
            lblTotalCapacityCount.Text = db.Location.Sum(x => x.Capacity).ToString();
            lblGuideCount.Text = db.Guide.Count().ToString();
            lblAvgCapacityCount.Text = Math.Round((decimal)db.Location.Average(x => x.Capacity), 2).ToString();
            lblAvgTourPriceCount.Text = Math.Round((decimal)db.Location.Average(x => x.Price), 2).ToString() + " ₺";
            lblLastAddedCountryName.Text = db.Location.Where(x => x.LocationId == (db.Location.Max(y => y.LocationId))).Select(z => z.Country).FirstOrDefault();
            lblKapadkoyaTourCapacityCount.Text = db.Location.Where(x => x.City == "Kapadokya").Select(y => y.Capacity).FirstOrDefault().ToString();
            lblTurkiyeAvgCapacityCount.Text = db.Location.Where(x => x.Country == "Türkiye").Average(y => y.Capacity).ToString();
            var romaGuideId = db.Location.Where(x => x.City.Contains("Roma")).Select(y => y.GuideId).FirstOrDefault();
            lblRomaGuideName.Text = db.Guide.Where(x=>x.GuideId == romaGuideId).Select(y=>y.GuideName + " " + y.GuideSurname).FirstOrDefault().ToString();
            var maxCapacity = db.Location.Max(y => y.Capacity);
            lblMostCapacityTourName.Text = db.Location.Where(x=>x.Capacity == maxCapacity).Select(y=>y.City).FirstOrDefault().ToString();
            decimal mostExpensiveTour = decimal.Parse(db.Location.Max(x=>x.Price).ToString());
            lblMostExpensiveTourCount.Text = db.Location.Where(x=>x.Price ==  mostExpensiveTour).Select(y=>y.City).FirstOrDefault().ToString();
            var aysegulCinarId = db.Guide.Where(x=>x.GuideName == "Ayşegül" && x.GuideSurname == "Çınar").Select(y=>y.GuideId).FirstOrDefault();
            lblAysegulsTourCount.Text = db.Location.Where(x => x.GuideId == aysegulCinarId).Count().ToString();
        }
    }
}
