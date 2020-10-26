using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_6115261020_w10_midterm
{
    class Paper
    {
        private string paperName;
        private string page;
        private string date;
        private string qualityLevel;
        private string weight;


        public Paper(string paperName, string page, string date, string qualityLevel, string weight)
        {
            this.PaperName = paperName;
            this.Page = page;
            this.Date = date;
            this.QualityLevel = qualityLevel;
            this.Weight = weight;
        }


        public string PaperName { get => paperName; set => paperName = value; }
        public string Page { get => page; set => page = value; }
        public string Date { get => date; set => date = value; }
        public string QualityLevel { get => qualityLevel; set => qualityLevel = value; }
        public string Weight { get => weight; set => weight = value; }

    }
}
