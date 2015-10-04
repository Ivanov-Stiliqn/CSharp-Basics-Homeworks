using System;
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Ime: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Familiq: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Godini: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Pol(m = male, f=famale): ");
            char gender = char.Parse(Console.ReadLine());
            Console.WriteLine("Personal ID number");
            long ID = long.Parse(Console.ReadLine());
            Console.WriteLine("Unique employee number");
            int UEN = int.Parse(Console.ReadLine());
            Console.WriteLine(
                "Ime: {0}"+" "+
                "Familiq: {1}"+" "+
                "Godini: {2}"+" "+
                "Pol: {3}"+" "+
                "ID: {4}"+" "+
                "UEN: {5}",
                firstName,lastName,age,gender,ID,UEN);
        }
    }
