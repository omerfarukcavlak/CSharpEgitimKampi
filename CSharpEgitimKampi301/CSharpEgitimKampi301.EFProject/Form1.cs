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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        EgitimKampiEfTraveDbEntities db = new EgitimKampiEfTraveDbEntities();
        private void btnList_Click(object sender, EventArgs e)
        {

            var values = db.Guide.ToList();
            dgvList.DataSource = values;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Guide guide = new Guide();
            guide.GuideName = tbxGuideName.Text;
            guide.GuideSurname = tbxGuideSurname.Text;
            db.Guide.Add(guide);
            db.SaveChanges();
            MessageBox.Show("Rehber başarıyla eklendi.");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(tbxRGuideId.Text);
            var removeValue  = db.Guide.Find(id);
            db.Guide.Remove(removeValue);
            db.SaveChanges();
            MessageBox.Show("Rehber başarıyla silindi.");

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(tbxRGuideId.Text);
            var updateValue = db.Guide.Find(id);
            updateValue.GuideName = tbxGuideName.Text;
            updateValue.GuideSurname= tbxGuideSurname.Text;
            db.SaveChanges();
            MessageBox.Show("Rehber başarıyla güncellendi.","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);

        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            int id = int.Parse(tbxRGuideId.Text);
            var values = db.Guide.Where( x => x.GuideId==id).ToList();
            dgvList.DataSource = values;
        }
    }
}
