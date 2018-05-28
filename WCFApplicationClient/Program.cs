using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCFApplicationClient.ServiceReference1;

namespace WCFApplicationClient
{
    class Program
    {
        static void Main(string[] args)
        {
            LibraryClient client = new LibraryClient();
            for (int i = 0; i < 10; i++)
            {
                var book = new Book()
                {
                    Idk__BackingField = i + 1,
                    Authork__BackingField = "bee",
                    Titlek__BackingField = "buu",
                    Pricek__BackingField = (i + 1) * 10,
                    Yeark__BackingField = 2010
                };
                client.AddBook(book);
                Console.WriteLine(client.AllBooks().Length);
            }
            Console.ReadLine();
        }
    }
}
