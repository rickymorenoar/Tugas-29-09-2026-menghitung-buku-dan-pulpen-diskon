using System;

namespace Tugas
{
    class Home
    {
        static void Main(string[] args)
        {
            int buku1 = 100;
            int buku2 = 200;
            int buku3 = 300;
            int bulpen = 500;


            int barangDiskon = buku1 + buku2 + buku3 + (bulpen * 2);

            double total = barangDiskon - buku1; 

           
            if (total >= 1000)
            {
                total = total - (total * 0.20);
            }
            else if (total >= 700)
            {
                total = total - (total * 0.10);
            }

            Console.WriteLine("Bayar : " + total);
        }
    }
}