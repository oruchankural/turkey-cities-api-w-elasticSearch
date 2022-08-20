using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Turkey_Cities_Api.Abstract;
using Turkey_Cities_Api.Entites;

namespace Turkey_Cities_Api.Services
{
    public class GetCitiesService : IGetCities
    {
        // Please change ur file path ! , U can use ur custom city json file
        static string citiesJson = @"C:\Users\Editor\source\repos\Turkey-Cities-Api\Turkey-Cities-Api\Data-Sources\allcities.json";
        public async Task<List<Cities>> LoadJson()
        {
            using (StreamReader sr = new StreamReader(citiesJson))
            {
                string json = await sr.ReadToEndAsync();
                List<Cities> cities = JsonConvert.DeserializeObject<List<Cities>>(json);
                return cities;
            }
           
        }
        // It's for the other data types as Enum , as Arr and more...
        public async Task<dynamic> LoadJsonWithoutClass()
        {
            using (StreamReader sr = new StreamReader(citiesJson))
            {
                string json = await sr.ReadToEndAsync();
                dynamic array = JsonConvert.DeserializeObject(json);
                return array;
            }
        }
    }
}
