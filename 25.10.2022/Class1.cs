using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25._10._2022
{
    internal class Class1
    {
        //public  void Yaz() { }
        //public void Yaz(int sayi) { }
        //public void Yaz(string sayi) { }
        ////metodların aşırı yüklenmesine örnek, imza 
        /// <summary>
        /// 3 slas at açıklama için
        /// </summary>
        /// <param name="sayi1"></param>
        /// <param name="sayi2"></param>
        /// <returns></returns>
        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        public double Topla(double sayi1, double sayi2)
        {
            return sayi1 + sayi2;
        }
        public float Topla(float sayi1, float sayi2)
        {
            return sayi1 + sayi2;
        }
        public decimal Topla(decimal sayi1, decimal sayi2)
        {
            return sayi1 + sayi2;
        }
        public long Topla(long sayi1, long sayi2)
        {
            return sayi1 + sayi2;
        }

    }
}
