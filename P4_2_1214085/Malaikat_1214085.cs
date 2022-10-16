using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_1214085
{
    public class Malaikat_1214085
    {
        private string myMalaikat;
        private string myTugas;

        public Malaikat_1214085()
        {

        }

        public Malaikat_1214085(string Malaikat, string tugas)
        {
            this.myMalaikat = Malaikat;
            this.myTugas = tugas;
        }

        public string MyMalaikat
        {
            get
            {
                return myMalaikat;
            }
            set
            {
                myMalaikat = value;
            }
        }
        public string MyTugas
        {
            get
            {
                return myTugas;
            }
            set
            {
                myTugas = value;
            }
        }
    }
}
