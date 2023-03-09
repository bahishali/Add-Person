using System;
using System.Collections;

/*
enum
ENUM enumları ifade edebileceğimiz sınıflar

*/

//enum DayEnum
//{
//    monday,
//    tuesday,
//    wednesday,
//    thursday,
//    friday,
//    saturday,
//    sunday
//}


namespace Samp1
{
    internal class Program
    {
        class Kisi
        {
            //public Kisi(string soyad)
            //{
            //    Surname = surname;
            //}
            public Kisi(string name, string surname)
            {
                Name = name;
                Surname= surname;
            }
            public string Name { get; set; }
            public string Surname { get; set; }

        }
        //static void Main(string[] args)
        //{
        //    Samp1(DayEnum.tuesday);
        //}
        //static void Samp1(DayEnum chosenDay)
        //    {
        //        switch (chosenDay)
        //        {
        //            case DayEnum.monday:
        //                Console.WriteLine("Monday");
        //                break;
        //            case DayEnum.tuesday:
        //                Console.WriteLine("Tuesday");
        //                break;
        //            case DayEnum.wednesday:
        //                Console.WriteLine("Wednesday");
        //                break;
        //            case DayEnum.thursday:
        //                Console.WriteLine("Thursday");
        //                break;
        //            case DayEnum.friday:
        //                Console.WriteLine("Friday");
        //                break;
        //            case DayEnum.saturday:
        //                Console.WriteLine("Saturday");
        //                break;
        //            case DayEnum.sunday:
        //               Console.WriteLine("Sunday");
        //                break;
        //            default:
        //                break;
        //        }
        //    }
        static void Samp2()
        {
            Kisi k1 = new Kisi("Veli", "Demir"); // Kisi olduğunu hatırlatmamız lazım
            Kisi k2 = new Kisi("Bus", "Ahis");

            ArrayList list = new ArrayList();
            list.Add(k1);
            list.Add(k2);
            
            List<Kisi> kisiler = new List<Kisi>();
            kisiler.Add(k1);
            kisiler.Add(k2);



        }

        //public class MyList : IEnumerator
        //{
        //    public object Current { get; set; } 
        //}



        }
    }
}