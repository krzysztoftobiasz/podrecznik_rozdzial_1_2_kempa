using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_podręcznik
{
    class Program
    {
        //wykonujemy dzialanie arytmetyczne
        /* static void Main(string[] args)
        {
             int x = 5;

             Console.WriteLine(x * x); //pomnóż zmienną x razy x
             Console.ReadKey();
          */
        /* int a, b, wynik;
         a = 4;
         b = 1;
         wynik = 2 * a - 3 * b;
         Console.WriteLine(wynik);
         Console.ReadKey(); 
         }
         */

        //obliczanie temperatury w stopniach farentheita
        /* static void Main(string[] args)
         {
             double F, C; //operator double ponieważ stosujemy liczby rzeczywiste
         Console.WriteLine("Podaj temperaturę w stopniach Farentheita");
         F = double.Parse(Console.ReadLine()); //metoda readline wczytuje dane typu string, double.Parse zamienia typ na double.
         C = 5d / 9 * (F - 32);  //używamy modyfiktora typu sufiks(tuż za liczbą, bez spacji) i zmieniamy typ 5 z int na double
         Console.WriteLine(C);
         Console.ReadKey();
         }
         */

        //Wykonujemy program, który zaprezentuje rzutowanie na przykładzie obliczania stosunku liczby studentów do komputerów
        /* static void Main(string[] args)
     {
         const int komputery = 24;
         int studenci;
         double wynik;
         Console.WriteLine("Podaj liczbę studentów");
         studenci = Convert.ToInt32(Console.ReadLine());
         wynik = (double)studenci / komputery;
         Console.WriteLine( wynik);
         Console.ReadKey();
     }
     */
        /* static void Main(string[] args) //y= pierwiastek z sinusx * logarytm o podst. 2 z x 
             {
             double x, y;
             Console.WriteLine("Podaj x (większe od 0): ");
             x = Convert.ToDouble(Console.ReadLine());
             y = Math.Sqrt(Math.Abs(Math.Sin(x)) * Math.Log(x, 2.0));
             Console.WriteLine(y);
             Console.ReadKey();
         }
         */
        /*static void Main(string[] args)
       {
           int x = 0, y;
           y = ++x * 2;
           Console.WriteLine(x);
           Console.WriteLine(y);
           Console.ReadKey();
       }
    */

        /*static void Main(string[] args)
        {
             int x, y = 4;
             x = (y += 3);
             x = ++y;
             x = y--;
             Console.WriteLine(x);
             Console.WriteLine(y);
             Console.ReadKey();
             }
        */
        /* static void Main(string[] args)
         {
             int x, y = 5;
             x = ++y;
             x = y++;
             x = --y;
             x = y--;
             Console.WriteLine(y++);
             Console.ReadKey();
         }
         */
         /* static void Main(string[] args) //program wyświetla true jeśli wiek bedzie >= 18 i PLN >+ 20, w przeciwnym razie false.
        {
            double wiek, PLN;
            bool kino;
            Console.WriteLine("Podaj wiek: ");
            wiek = double.Parse(Console.ReadLine());
            Console.WriteLine("Ile masz pieniędzy: ");
            PLN = double.Parse(Console.ReadLine());
            kino = (wiek >= 18 && PLN >= 20);
            Console.WriteLine(kino);
            Console.ReadKey();
          }      
            */
          /*  static void Main (string[] args) //przykład 2.10
        {
            int x = 1, y = 2;
            bool wynik;
            wynik = (++x >= 2 && y++ >= 2);
            Console.WriteLine(wynik);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.ReadKey();
        }
        */
         /*   static void Main (string[] args) //przykład 2.11
        {
            int x = 3, y = 10;
            bool wynik;
            wynik = (x >= 2 || y++ >= 2);
            Console.WriteLine(wynik);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.ReadKey();
        }
         */
         /*static void Main (string[] args)// przykład 2.12
        {
            int x = 1, y = 2, z = 3;
            bool wynik;
            wynik = (x == 1 || y != 5 && z < 1);
            Console.WriteLine(wynik);
            Console.ReadLine();

         }
        */
           /* static void Main(string[] args) //program poprosi o wpisanie tekstu, następnie wyświetli komunikat, ponadto wyświetli liczbę znaków
        {
            string tekst;
            Console.WriteLine("Podaj imię");
            tekst = Console.ReadLine();
            tekst = "Cześć " + tekst;
            Console.WriteLine(tekst);
            Console.WriteLine(tekst.Length); // wyświetli liczbę znaków
            Console.ReadKey();
            }
            */
          /*  static void Main(string[] args) // mój pierwszy program ;)
        {
            int x, y, wynik;
            Console.WriteLine("Wpisz liczbę którą chcesz pomnożyć:");
           x= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Wpisz drugą liczbę:");
            y = Convert.ToInt32(Console.ReadLine());
            wynik = x * y;
            Console.WriteLine("Wynik to: " + wynik);
            Console.ReadKey();
        }
        */
          /*  static void Main(string[] args) //ściąga znaki specjalne
        {
            Console.WriteLine("Linia1\nLinia2"); // przejście do nowej linii
            Console.WriteLine("Wzrost 170\tWaga65"); // \t-tabulacja
            Console.WriteLine(@"Wzrost 170\tWaga 65"); // @-dosłowna interpretacja
            Console.WriteLine("C:\\Windows\\Temp"); // podwójny "\\" wstawia "\"
            Console.WriteLine("Tytuł filmu: \"Forrest Gump\""); // znak\" wstawia znak "
            Console.ReadKey();
        }
        */
      /*  static void Main(string[] args) //kolejność wykonywania działań
        {
            int a, b, c = 10;
            a = b = c;                      //tutaj wykonuje się od prawej do lewej
            Console.WriteLine(a);
            Console.WriteLine(a + b + c);   //tutaj natomiast od lewej do prawej.
            Console.ReadKey();

        }
        */
         /*  static void Main(string[] args) //przykład 2.17
        {
            int x = 1, y = 1;
            Console.WriteLine(x++ + 2 * ++y);
            Console.ReadKey();
        }
        */
           /* static void Main(string[] args) //przykład 2.18
        {
            int x = 10, y = 25;
            Console.WriteLine("Suma=" + x + " Iloczyn=" + y);
            Console.WriteLine("Suma={0} Iloczyn={1}", x, y);
            Console.ReadKey();
        }
        */

       /* static void Main(string[] args) //przykład 2.19
        {
            int suma = 10;
            double x = 12.345678, y = 24.56, wskaznik = 0.45;
            string imie = "Ala", naz = "Nowak";
            Console.WriteLine("1. Imię: {0,15} Nazwisko: {1,20}", imie, naz); //zmienna wyswietla się na 15 lub 20 znakach i równa do prawej
            Console.WriteLine("2. Imię: {0,-15} Nazwisko: {1,-20}", imie, naz); //to samo tylko wyrównanie do lewej
            Console.WriteLine("3. Wartość {0,10} to suma", suma); 
            Console.WriteLine("4. Wartosć {0,-10} to suma", suma);
            Console.WriteLine("5. Wskaźnik: {0,8:P}", wskaznik); //format procentowy
            Console.WriteLine("6. Waga: {0,10} kg", x);
            Console.WriteLine("7. {0,-10:F4} (4 cyfry po przecinku)", x); // F4-specyfikator formatujący (wyświetla 4 miejsca po przecinku)
            Console.WriteLine("8. Wartość x={0, -10:F4} y={1, -10:F2}", x, y);
            Console.WriteLine("9. A ta liczba będzie w klamrach {{{0}}}", y);
            Console.ReadKey();
        }
          */
       /*   static void Main(string[] args) //program przelicz temperaturę
        {
            double F, C;
            
            Console.WriteLine("Podaj temperaturę w stopniach Celsjusza:");
            C = double.Parse(Console.ReadLine());
            F=32 + 9/5d * C;
            Console.WriteLine("Temperatura w stopniach Farenheita to: {0}", F);
            Console.ReadKey();

        }
        */
         /*   static void Main(string[] args) //program liczy delte
        {
            double delta, a, b, c;
            Console.WriteLine("Podaj współczynnik a: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj współczynnik b: ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj współczynnik c: ");
            c = double.Parse(Console.ReadLine());
            delta = (b * b) - (4 * a * c);
            Console.WriteLine("Delta jest równa: {0}",delta);
            Console.ReadKey();
        }
        */



    }


}


