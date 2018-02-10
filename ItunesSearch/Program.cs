using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItunesSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an artist name");
            var userQuery = Console.ReadLine();

            var searchManager = new ItunesSearchManager(new ItunesSearchClient());

            searchManager.GetCollections(userQuery);
        }
    }
}
