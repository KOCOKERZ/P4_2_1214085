using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_1214085
{
    internal class MalaikatTest_1214085
    {
        static void Main(string[] args)
        {
            Malaikat1_1214085 malaikat1 = new Malaikat1_1214085("Jibril", "membawa wahyu");
            Malaikat2_1214085 malaikat2 = new Malaikat2_1214085( "membawa rezeki");
            Malaikat3_1214085 malaikat3 = new Malaikat3_1214085("meniup sangkakala");
            Malaikat4_1214085 malaikat4 = new Malaikat4_1214085("mencabut nyawa");
            Malaikat5_1214085 malaikat5 = new Malaikat5_1214085("bertanya dalam kubur mengenai amalan buruk");
            Malaikat6_1214085 malaikat6 = new Malaikat6_1214085("bertanya dalam kubur mengenai amalan baik");
            Malaikat7_1214085 malaikat7 = new Malaikat7_1214085("mencatat amal baik");
            Malaikat8_1214085 malaikat8 = new Malaikat8_1214085("mencatat amal buruk");
            Malaikat9_1214085 malaikat9 = new Malaikat9_1214085("menjaga pintu neraka");
            Malaikat10_1214085 malaikat10 = new Malaikat10_1214085("menjaga pintu surga");

            Console.WriteLine("Malaikat {0} bertugas {1}", malaikat1.MyMalaikat, malaikat1.MyTugas);
            Console.WriteLine("Malaikat {0} bertugas {1}", malaikat2.MyMalaikat, malaikat2.MyTugas);
            Console.WriteLine("Malaikat {0} bertugas {1}", malaikat3.MyMalaikat, malaikat3.MyTugas);
            Console.WriteLine("Malaikat {0} bertugas {1}", malaikat4.MyMalaikat, malaikat4.MyTugas);
            Console.WriteLine("Malaikat {0} bertugas {1}", malaikat5.MyMalaikat, malaikat5.MyTugas);
            Console.WriteLine("Malaikat {0} bertugas {1}", malaikat6.MyMalaikat, malaikat6.MyTugas);
            Console.WriteLine("Malaikat {0} bertugas {1}", malaikat7.MyMalaikat, malaikat7.MyTugas);
            Console.WriteLine("Malaikat {0} bertugas {1}", malaikat8.MyMalaikat, malaikat8.MyTugas);
            Console.WriteLine("Malaikat {0} bertugas {1}", malaikat9.MyMalaikat, malaikat9.MyTugas);
            Console.WriteLine("Malaikat {0} bertugas {1}", malaikat10.MyMalaikat, malaikat10.MyTugas);
        }
    }
}
