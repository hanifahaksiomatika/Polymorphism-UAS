using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAS_Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Documents documents;

            Console.WriteLine("Pilih Document Anda: ");
            Console.WriteLine("1. Word");
            Console.WriteLine("2. Excel");
            Console.WriteLine("3. Power Point");

            Console.WriteLine("\nNomor Document [1..3]: ");
            int nomorDocument = Convert.ToInt32(Console.ReadLine());

            if (nomorDocument == 1)
                documents = new Word();
            else if (nomorDocument == 2)
                documents = new Excel();
            else
                documents = new PowerPoint();

            documents.Open();
            documents.Save();*/

            Documents documents = new Documents();
            documents.Save();

            Word word = new Word();
            documents = word;              // polymorphism
            //word.Save();                 // polymorphism
            documents.Save();              // polymorphism


            Excel excel = new Excel();
            documents = excel;             // polymorphism
            //excel.Save();                // polymorphism
            documents.Save();              // polymorphism

            PowerPoint powerpoint = new PowerPoint();
            documents = powerpoint;        // polymorphism
            //powerpoint.Save();           // polymorphism
            documents.Save();              // polymorphism
            

            Console.ReadKey();
        }
    }
}
