using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr_32_prakt16_1_OAP_Kolyasnikova.V
{
    class MyException : Exception { }
    class Organizaciya
    {
        private string n;
        private string i;
        private string c;
        private string s;
        private string h;
        private string t;

        public string N
        {
            get { return n; }
            set {n = value;}
        }
        public string I
        {
            get { return i; }
            set
            {
                i = value;
                for (int i = 0; i < I.Length; i++)
                {
                    if (!char.IsDigit(I[i]))
                    {
                        throw new MyException();
                    }
                }
            }
        }
        public string C
        {
            get { return c; }
            set
            {
                c = value;
                for (int i = 0; i < C.Length; i++)
                {
                    if (Char.IsDigit(C[i]))
                        throw new MyException();
                }
            }
        }
        public string S
        {
            get { return s; }
            set
            {
                s = value;
                for (int i = 0; i < S.Length; i++)
                {
                    if (Char.IsDigit(S[i]))
                        throw new MyException();
                }
            }
        }
        public string H
        {
            get { return h; }
            set{ h = value;}
        }
        public string Telephone
        {
            get { return t; }
            set { t = value;}
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Organizaciya o = new Organizaciya();
                Console.Write("Название организации: ");
                o.N = Console.ReadLine();
                Console.Write("Почтовый индекс организации: ");
                o.I = Console.ReadLine();
                Console.Write("Город: ");
                o.C = Console.ReadLine();
                Console.Write("Улица: ");
                o.S = Console.ReadLine();
                Console.Write("Дом: ");
                o.H = Console.ReadLine();
                Console.Write("Номер телефона: ");
                o.Telephone = Console.ReadLine();
                Console.WriteLine("\nОрганизация:");
                Console.WriteLine("Название: " + o.N);
                Console.WriteLine("Почтовый индекс: " + o.I);
                Console.WriteLine("Город: " + o.C);
                Console.WriteLine("Улица, дом: " + o.S + ", " + o.H);
                Console.WriteLine("Номер телефона: " + o.Telephone);
            }
            catch (MyException)
            {
                Console.WriteLine("Неверный формат");
            }

            Console.ReadKey();
        }
    }
}
