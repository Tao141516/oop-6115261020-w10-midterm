using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop_6115261020_w10_midterm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string code = txtNum.Text;
            string name = txtName.Text;
            string work = txtWork.Text;
            string page = txtPage.Text;
            string paper = txtPaper.Text;
            string date = txtDate.Text;
            string qualityLavel = txtQualityLevel.Text;
            string weight = txtWeight.Text;
            Person per = new Person(code, name, work);
            Paper pa = new Paper(page, paper, date, qualityLavel, weight);
            lblShow.Text = per.Code + " " + per.WorkOwnerName + " " + per.WorkName + " " +
                pa.Page + " " + pa.PaperName + " " + pa.Date + " " + pa.QualityLevel + " " + pa.Weight;

        }
    }
}
