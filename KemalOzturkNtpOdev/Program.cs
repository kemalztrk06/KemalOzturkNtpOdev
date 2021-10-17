using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KemalOzturkNtpOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream(@"C:\odev\odev.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            Console.Write("Araç sayısını giriniz:");
            int number = Convert.ToInt16(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                Tasit tasit = new Tasit();
                Araba araba = new Araba();
                Console.Write("Aracın markasını giriniz:");
                tasit.Marka = Console.ReadLine();
                Console.Write("Aracın modelini giriniz:");
                tasit.Model = Console.ReadLine();
                Console.Write("Aracın rengini giriniz:");
                tasit.Renk = Console.ReadLine();
                Console.Write("Aracın motor gücünü giriniz:");
                araba.Motor = Console.ReadLine();
                Console.Write("Aracın kilometresini giriniz:");
                araba.Km = Console.ReadLine();
                Console.Write("Aracın yılını giriniz: ");
                araba.Yıl = Console.ReadLine();
                sw.WriteLine("Aracın Markası: " + tasit.Marka + "  -  "
                + "Aracın Modeli: "    + tasit.Model + "  -  " + "Aracın Rengi: " + tasit.Renk + "  -  " + "Aracın Motoru: " + araba.Motor + "  -  " + "Aracın kilometresi: " + araba.Km + "  -  " + " Aracın yılını giriniz: " + araba.Yıl);
                Console.Clear();

            }
            sw.Close();
            Console.WriteLine("Araç bilgileriniz dosyaya başarıyla aktarıldı.");
            Console.ReadKey();
        }
    }
}
