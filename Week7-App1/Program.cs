using System;

class Program
{

    static public void Main(string[] args)
    {

        List<int> intList = new List<int>() { 20, 302, 23, 67, 32, 85, 22, 78,-63,-21,-88,-215, -100 , - 76 };

        Console.WriteLine("Çift Sayılar....");
        var cift = intList.Where(num => num % 2 == 0);
        foreach (var num in cift)
        {
            Console.WriteLine(num);
        }
        Console.WriteLine("Tek Sayılar....");
        var tek = intList.Where(num => num % 2 != 0);
        foreach ( var num in tek)
        {
            Console.WriteLine(num);
        }
        Console.WriteLine("Positif Sayılar....");
        var positifSayi =  intList.Where(num => num > 0);
        foreach( var num in positifSayi)
        {
            Console.WriteLine(num);
        }
        Console.WriteLine("15den büyük,22den küçük sayılar");
        var besinciKosul = intList.Where(num => num > 15 && num < 22);
        foreach (var num in besinciKosul)
        {
            Console.WriteLine(num);
        }

        List<int> sayilar = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };
        Console.WriteLine("1den 7 ye kadar olan sayıların karesi");
        var kare = sayilar.Select(num => num * num);
        foreach (var num in kare)
        {
            Console.WriteLine(num);
        }



    }


}

