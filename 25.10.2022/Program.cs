//metodlarda imza

using _25._10._2022;

Console.WriteLine(); //18 tane versiyonu var
// yani 18 tane cw var
// ayni alan içerisinde (scope) aynı isimliaynı parametre şekli ile birden fazla metod yazılmaz 
// aynı isimli birden fazla metod yazmak ister isek metodların farklı imzası olmalıdır.
// neye göre oluşur (parametre)
// 1- parametre sayısı
// 2- parametre tipleri
// biribirinde farklı olduğu sürece aynı isimli n tane metod yazılabilir , Bu olaya metodların aşırı yüklenmesi denir. (methods overloading)

Class1 deneme=new Class1();
Console.WriteLine(deneme.Topla(4.6, 5));

//metodlarda params kullanımı

int Topla1(int sayi1, int sayi2)
{
    return sayi1 + sayi2;
}
int Topla2(int sayi1, int sayi2, int sayi3)
{
    return sayi1 + sayi2 + sayi3;
}
int Topla3(int sayi1, int sayi2, int sayi3, int sayi4)
{
    return sayi1 + sayi2 + sayi3 + sayi4;
}
Console.WriteLine(Topla1(3,4));
Console.WriteLine(Topla2(3,4,4));
Console.WriteLine(Topla3(3,4,5,6));

////////////// kısa yolu
// bir metodda sadece bir params olabilir
//int deneme(params int[] a,params int[] b)
//{
   //iki tane olursa diziyi ayıramaz 
//}
//params kullanılacaksa en son parametre yazılmalıdır ki nereden itibaren dizi olacağını bilmesi lazım
int Topla(params int[] sayılar)  // gönderilen tüm değerler diziye çevrilir
{
    int toplam = 0;

    foreach (int s in sayılar )
    {
        toplam += s;
    }    
    return toplam;
}

string str = "selam";
str.Split(); // bunun sonucunda dizinin dizisi oluşur

// params parametleri virgülle gönderip sayısını değiştiririz

//------------------

// c# 4.0(2010) yılı ile birlikte default parameters(optional parameter) ve named parameters gelmiştir
// ctrl d alt satıra koplayalar
void Islem(int a, int b, int c=12)
{
    Console.WriteLine($"{a},{b},{c}");
}
//üç tane parametre girmemiz lazım ama c ye değişken attığımız varsayılan değer alır
Islem(1,2,3); /*c nin değeri 3*/  Islem(1,2);  /*c nin değeri 12(optinal ya da default parametre)*/

//named parameters
Islem(c: 1,b:34,a:23); //tanımlandığı sıraya bağlı kalamadan parametrelere değer gönderebiliriz

//Recursive Function(Metods) 
//Kendi kendini çağıran metodlar
//Özyinelemeli metodlar
int Faktoriyel(int sayi)
{
    if (sayi == 1) return 1; //recursive fonksiyonlarda sonlandırıcı olmak zorunda
    return sayi * Faktoriyel(sayi - 1);
}
Console.WriteLine(Faktoriyel(5));
// bir işin kaç kere yapılacağı bilinmiyorsa bu metod kullanılır