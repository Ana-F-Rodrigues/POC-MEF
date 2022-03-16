using BSIL.POC.MEFDatabase;
using System;
using System.Composition;

namespace BSIL.POC.ConsoleApp
{

    public class Program
    {

        static void Main(string[] args)
        {
           
            Console.WriteLine("Carregando a DLL do banco de dados usando o catálogo de diretorios");
            Container container = new Container();

            Console.WriteLine(string.Empty);
            Console.WriteLine("Conectando ao banco de dados");
            bool isLoggedIn = container.Database.Login("username", "password");

            Console.WriteLine(string.Empty);
            Console.WriteLine("Estou  {0}conectado usando {1}", isLoggedIn ? string.Empty : "not ", container.Database.DatabaseName);
            Console.ReadLine();
        }
    }
}


