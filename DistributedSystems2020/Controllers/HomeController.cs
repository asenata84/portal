using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DistributedSystems2020.Models;
using System.Net;
using Newtonsoft.Json;
using System.IO;
using System.Threading;
using System.Web.Script.Serialization;

namespace DistributedSystems2020.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var viewModel = new IndexViewModel()
            {
                Title = "News",
            };

            var url = "https://rapidapi.p.rapidapi.com/news/search/";

            try
            {
                var client = new WebClient();

                client.Headers.Add("x-bingapis-sdk", "true");
                client.Headers.Add("x-rapidapi-key", "95b6b49d51mshc3aaba005beecafp11e5f6jsnaab25d1c5d89");
                client.Headers.Add("x-rapidapi-host", "bing-news-search1.p.rapidapi.com");
                client.Headers.Add("useQueryString", "true");

                var body = client.DownloadString(url);

                viewModel.News = JsonConvert.DeserializeObject<NewsModel>(body);
            }
            catch (Exception)
            {
                
            }

            return View(viewModel);
        }

        public ActionResult Covid()
        {
 
            var viewModel = new IndexViewModel()
            {
                Title = "Covid-19",
            };

            DateTime dateTime = DateTime.UtcNow.Date;
            var today = dateTime.ToString("yyyy-MM-dd");
            var url = "https://rapidapi.p.rapidapi.com/history?country=bulgaria&day=" + today;

            var client = new WebClient();
            client.Headers.Add("x-rapidapi-key", "95b6b49d51mshc3aaba005beecafp11e5f6jsnaab25d1c5d89");
            client.Headers.Add("x-rapidapi-host", "covid-193.p.rapidapi.com");
            client.Headers.Add("useQueryString", "true");
 
            Stream data = client.OpenRead(url);
            StreamReader reader = new StreamReader(data);
            string s = reader.ReadToEnd();
  
            data.Close();
            reader.Close();
            var body = "";

            body = client.DownloadString(url);

            viewModel.Covid = JsonConvert.DeserializeObject<CovidModel>(body);

            return View(viewModel);
        }

        public ActionResult Weather(string city)
        {
            var viewModel = new WeatherModel()
            {
                City = city
            };

            if (city != null && city != "")
            {
                var apiKey = "5afa920673234dc90e1018bf6f4ceeb2";
                var info = new WebClient()
                    .DownloadString(
        $"http://api.openweathermap.org/data/2.5/weather?q={city}&appid={apiKey}&units=metric");

                viewModel.Weather = JsonConvert.DeserializeObject<WeatherInfo>(info);
            }


            return View(viewModel);
        }


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            var a = "about";
            var b = a;

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

    }
}