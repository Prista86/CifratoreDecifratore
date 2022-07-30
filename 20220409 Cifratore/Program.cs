using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20220409_Cifratore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string alfabetoChiaro = "abcdefghijklmnopqrstuvwxyz";
            //string alfabetoChiaro = "abcde";
            char carattere;
            int slittatura = 1;
            int j = 0;
            int n = 0;
            string messaggioChiaro;
            string messaggioCifrato;
            string[] alfabetoCifrante = new string[alfabetoChiaro.Length];



            Console.WriteLine("Di quanto vuoi 'slittare' l'alfabeto ?");                        //Slittatura Alfabeto
            Console.WriteLine($"Inserire un numero da 1 a {(alfabetoChiaro.Length-1)}");
            slittatura = int.Parse(Console.ReadLine());
            Console.WriteLine($"Alfabeto CHIARO:     {alfabetoChiaro}");
            Console.Write($"Alfabeto CIFRANTE:   ");
            for (int i = 0; i < alfabetoChiaro.Length; i++)
            {
                if (slittatura + i > (alfabetoChiaro.Length - 1))
                {
                    j = 0;
                    slittatura = 0;
                }                
                carattere = alfabetoChiaro[slittatura + j];
                alfabetoCifrante[i] = carattere.ToString();
                Console.Write(alfabetoCifrante[i]);
                j++;                
            }


            Console.ReadKey();                                                          //cifra parola
            Console.WriteLine("");
            Console.WriteLine("Inserisci la parola da Cifrare");
            messaggioChiaro = Console.ReadLine();
            messaggioCifrato = "";
            for (int i = 0; i < messaggioChiaro.Length; i++)
            {
                char LetteraParola = messaggioChiaro[i];
                int posizione = alfabetoChiaro.IndexOf(LetteraParola);
                string letteraCifrata = alfabetoCifrante[posizione];
                messaggioCifrato += letteraCifrata;

            }
            Console.WriteLine(messaggioCifrato);
            Console.ReadKey();

            Console.ReadKey();                                                                          //decifra parola
            Console.WriteLine("");
            Console.WriteLine("Inserisci la parola Cifrata");
            messaggioCifrato = Console.ReadLine();

            Console.WriteLine("Inserisci il numero dello slittamento");
            slittatura = int.Parse(Console.ReadLine());

            //messaggioCifrato = "";
            messaggioChiaro = "";
            for (int i = 0; i < messaggioCifrato.Length; i++)
            {
                char LetteraParola = messaggioCifrato[i];
                int posizione = Array.IndexOf(alfabetoCifrante,LetteraParola.ToString());
                char letteraCifrata = alfabetoChiaro[posizione];
                messaggioChiaro += letteraCifrata;

            }
            Console.WriteLine(messaggioChiaro);
            Console.ReadKey();
        }
    }
}
