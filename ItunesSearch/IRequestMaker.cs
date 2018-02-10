using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItunesSearch
{
    interface IRequestMaker
    {
        ItunesCollection MakeRequest(string query);
    }
}
