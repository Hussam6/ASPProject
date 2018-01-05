using Project.Models.LocationModel;
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
using System.Net;
using System.Net.Sockets;

namespace Project.Controllers
{
    public class GeoLocation : Controller
    {
        public static string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("No network adapters with an IPv4 address in the system!");
        }
        // GET: API
        public static Rootobject GetLocation()
        {
            string apiUrl = "https://simple-weather.p.mashape.com/weatherdata?";
            string ips = GetLocalIPAddress();
            Task<HttpResponse<string>> response = Unirest.get(apiUrl)
           .header("X-Mashape-Key", "MjvESZoQ1zmsh4mAPB13PdSiaFhkp1l6vHpjsnZm5dLZn4qD9b")
           .header("Content-Type", "application/x-www-form-urlencoded")
            .header("Accept", "application/json")
            .field("ip", ips)
            .field("reverse-lookup", false)
           .asJsonAsync<string>();

            string r = response.Result.Body;
            var rootresult = JsonConvert.DeserializeObject<Rootobject>(r);
            return rootresult;

        }


        public ViewResult Location()
        {
            Rootobject r = GetLocation();
            return View("Index", r);
        }
    }
}