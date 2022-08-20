using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Turkey_Cities_Api.Entites;

namespace Turkey_Cities_Api.Abstract
{
    public interface IGetCities
    {
        
        Task<List<Cities>>LoadJson();
        Task<dynamic> LoadJsonWithoutClass();
        

    }
}
