using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAS_Polymorphism
{
    public class Documents
    {
        public string Name { get; set; }    // properties

        // method
        /*public virtual void Open()
        {
            Console.WriteLine("Membuka Document...");
        }*/
        public virtual void Save()
        {
            Console.WriteLine("Save Document\n");
        }
    }
    public class Word : Documents
    {
        /*public override void Open()
        {
            Console.WriteLine("Membuka Document Word...");
        }*/
        public override void Save()
        {
            Console.WriteLine("Document: .docx tersimpan");
        }
    }
    public class Excel : Documents
    {
        /*public override void Open()
        {
            Console.WriteLine("Membuka Document Excel...");
        }*/
        public override void Save()
        {
            Console.WriteLine("Document: .xls tersimpan");
        }
    }
    public class PowerPoint : Documents
    {
        /*public override void Open()
        {
            Console.WriteLine("Membuka Document PowerPoint...");
        }*/
        public override void Save()
        {
            Console.WriteLine("Document: .ppt tersimpan");
        }
    }
}
