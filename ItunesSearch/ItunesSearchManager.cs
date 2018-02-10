using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItunesSearch
{
    class ItunesSearchManager
    {

        private IRequestMaker _searchClient;

        public ItunesSearchManager(IRequestMaker _searchClient)
        {
            this._searchClient = _searchClient;
        }

        public void GetCollections(string query)
        {
            var collections =   _searchClient.MakeRequest(query);

            Console.WriteLine($"We have found {collections.resultCount} entries for your search");

            foreach (var eachCollections in collections.results)
            {
                Console.WriteLine(eachCollections.collectionName);
            }

            Console.ReadLine();
        }
    }
}
