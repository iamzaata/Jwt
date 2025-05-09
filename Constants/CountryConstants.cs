using Jwt.Models;

namespace Jwt.Constants
{
    public class CountryConstants   //clase que contiene una lista de paises
    {
        public static List<CountryModel> Countrys = new List<CountryModel>()
        {
            new CountryModel() { Name = "Argentina"},
            new CountryModel() { Name = "Peru"},    
            new CountryModel() { Name = "Mexico"},
        };
    }
}