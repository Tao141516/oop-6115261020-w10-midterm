using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_6115261020_w10_midterm
{
    class Person
    {
        private string code;
        private string workOwnerName;
        private string workName;


        public Person(string code, string workOwnerName, string workName)
        {
            this.code = code;
            this.workOwnerName = workOwnerName;
            this.workName = workName;
        }


        public string Code { get => code; set => code = value; }
        public string WorkOwnerName { get => workOwnerName; set => workOwnerName = value; }
        public string WorkName { get => workName; set => workName = value; }

    }
}
