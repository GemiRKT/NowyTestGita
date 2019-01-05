using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text;

namespace NowyTestGita
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ktore haslo chcesz zgadnac?: ");
            Console.WriteLine("1.Haslo Noraza");
            Console.WriteLine("2.Haslo Gomeza");
            Console.WriteLine("3.trzecia funkcja");
            Console.WriteLine("czwarta funkcja jaka dodamy");
            int wybor = Convert.ToInt32(Console.ReadLine());

            Hasla wpisz = new Hasla();
            Login stworz = new Login();
           
            switch (wybor)
            {
                case 1:  wpisz.HasloNoraza();
                    break;
                case 2:  wpisz.HasloGomeza();
                    break;
                case 3:  stworz.PodajLogin();
                    break;
                default:
                    Console.WriteLine("zly wybor, wybierz 1 lub 2 ");
                    break;
            }
            Console.ReadKey();
        }        
    }

    class Hasla
    {
        public void HasloGomeza()
        {
            while (true)
            {             
                Console.WriteLine("podaj slowo haslo:");
                String haslo = Console.ReadLine();
                if (haslo.Contains("tajemnica"))
                {
                    Console.WriteLine("Dobra robota");
                    break;
                }
                else
                {
                    Console.WriteLine("wpisz ponownie haslo");
                }
            }
        }
        public void HasloNoraza()
        {
            while (true)
            {
                String haslowpisane;
                String haslostale = "Zupa Pomidorowa";
                Console.WriteLine("Prosze podac haslo: ");
                haslowpisane = Console.ReadLine();
                if (haslowpisane.Equals(haslostale))
                {
                    Console.WriteLine("jestes super odgadles haslo");
                    break;
                }
                else
                {
                    Console.WriteLine("jestes BARAaaaaN spróbuj ponownie:");
                }
            }
        }
    }  

    class Login
    {
        public void PodajLogin()
        {
            Console.WriteLine("Podaj nazwe twojego konta");
            String NowyLogin = Console.ReadLine();
            Console.WriteLine("Witam {0} twoje konto zostalo utworzone",NowyLogin);
            File.AppendAllText(@"C:\Users\Kamil\source\repos\NowyTestGita\NowyTestGita\ListaLoginow", NowyLogin+Environment.NewLine);
            Console.ReadKey();
        }
    }
}
