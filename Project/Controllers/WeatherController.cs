using Project.Models.WeatherModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Net.Http;
using unirest_net.http;
using Newtonsoft.Json;
using System.Diagnostics;

namespace Project.Controllers
{
    public class WeatherController : Controller
    {
        // GET: API
        public static Rootobject GetWeather(string lat, string lon)
        {
            string apiUrl = "https://simple-weather.p.mashape.com/weatherdata?";
            string repUrl = apiUrl + "lat=" + lat + "&lng=" + lon;

             Task<HttpResponse<string>> response = Unirest.get(repUrl)
            .header("X-Mashape-Key", "MjvESZoQ1zmsh4mAPB13PdSiaFhkp1l6vHpjsnZm5dLZn4qD9b")
            .header("Accept", "application/json")
            .asJsonAsync<string>();
            
                string r = response.Result.Body;
                var rootresult = JsonConvert.DeserializeObject<Rootobject>(r);
                return rootresult;

        }

        
        public ViewResult Weather(LatLngModel x)
        {
            Debug.WriteLine("***** TEST : " + x.lat.ToString());
            Rootobject r = GetWeather("43", "-79");
            return View("Weather",r);
        }
        
        [HttpGet]
        public ViewResult WeatherForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult WeatherForm(LatLngModel x)
        {
            //Debug.WriteLine("***** TEST : " + x.lat.ToString());
            
            Rootobject r = GetWeather(x.lat.ToString(), x.lng.ToString());
            try
            {
                if (r.query.results.channel.astronomy.sunrise != null)
                {
                    return View("Weather", r);
                }
            } catch (NullReferenceException e)
            {
                return View();
            }
            return View();
            
        }



    }
}