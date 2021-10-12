using System;

public class Hello 
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
        string fname, lname, alamat, tgllahir;
        int umur;
        Console.Write("First Name : ");
        fname = Console.ReadLine();

        Console.Write("Last Name : ");
        lname = Console.ReadLine();

        Console.Write("Age : ");
        umur = int.Parse(Console.ReadLine());

        Console.Write("Address : ");
        alamat = Console.ReadLine();

        Console.Write("Birthday : ");
        tgllahir = Console.ReadLine();

        Console.WriteLine("");

        Console.WriteLine("Your name is " + fname + " " + lname);
        Console.WriteLine("You are " + umur + " years old");
        Console.WriteLine("You are born in " + tgllahir);
        Console.WriteLine("Address : " + alamat);
    }
}