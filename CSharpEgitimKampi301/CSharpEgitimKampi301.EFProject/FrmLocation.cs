using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.EFProject
{
    public partial class FrmLocation : Form
    {
        public FrmLocation()
        {
            InitializeComponent();
        }
        EgitimKampiEfTraveDbEntities db = new EgitimKampiEfTraveDbEntities();
        private void btnList_Click(object sender, EventArgs e)
        {
            var values = db.Location.ToList();
            dgvList.DataSource = values;
        }

        private void FrmLocation_Load(object sender, EventArgs e)
        {
            var values = db.Guide.Select(x => new
            {
                FullName = x.GuideName + " " + x.GuideSurname,
                x.GuideId
            }).ToList();
            cbxGuide.DisplayMember = "FullName";
            cbxGuide.ValueMember = "GuideId";
            cbxGuide.DataSource = values;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Location location = new Location();
            location.Capacity = byte.Parse(nudCapacity.Value.ToString());
            location.City = tbxCity.Text;
            location.Country = tbxCountry.Text;
            location.Price = decimal.Parse(tbxPrice.Text);
            location.DayNight = tbxDayNight.Text;
            location.GuideId = int.Parse(cbxGuide.SelectedValue.ToString());
            db.Location.Add(location);
            db.SaveChanges();
            MessageBox.Show("Ekleme işlemi başarılı");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(tbxLocationId.Text);
            var deletedValue = db.Location.Find(id);
            db.Location.Remove(deletedValue);
            db.SaveChanges();
            MessageBox.Show("Silme işlemi başarılı");

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(tbxLocationId.Text);
            var uptadedValue = db.Location.Find(id);
            uptadedValue.Capacity = byte.Parse(nudCapacity.Value.ToString());
            uptadedValue.City = tbxCity.Text;
            uptadedValue.Country = tbxCountry.Text;
            uptadedValue.Price = decimal.Parse(tbxPrice.Text);
            uptadedValue.DayNight = tbxDayNight.Text;
            uptadedValue.GuideId = int.Parse(cbxGuide.SelectedValue.ToString());
            db.SaveChanges();
            MessageBox.Show("Güncelleme işlemi başarılı");
        }

    }
}
