using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintCompanyInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ime na firmata: ");
            string companyName = Console.ReadLine();
            Console.Write("Adres na firmata: ");
            string companyAdress = Console.ReadLine();
            Console.Write("Nomer na firmata: ");
            string companyNumber = Console.ReadLine();
            Console.Write("Fax: ");
            string companyFax = Console.ReadLine();
            Console.Write("Website: ");
            string website = Console.ReadLine();
            Console.Write("Ime na manager: ");
            string firstName = Console.ReadLine();
            Console.Write("Familiq: ");
            string lastName = Console.ReadLine();
            Console.Write("Godini: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Telefonen nomer: ");
            string number =Console.ReadLine();
            Console.WriteLine(companyName);
            Console.WriteLine("Adres: {0}",companyAdress);
            Console.WriteLine("Tel: {0}",companyNumber);
            Console.WriteLine("Fax: {0}",companyFax);
            Console.WriteLine("Web: {0}",website);
            Console.WriteLine("Manger: {0} {1} (age: {2}, tel: {3})",firstName,lastName,age,number);
        }
    }
}
