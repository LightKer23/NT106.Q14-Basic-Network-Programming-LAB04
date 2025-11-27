using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bai04.Data;
using HtmlAgilityPack;
using System.Net.Http;

namespace Bai04.Data
{
    internal class MovieScraper
    {
        private readonly HttpClient http = new();

        private const string URL = "https://betacinemas.vn/phim.htm";

        public async Task<List<Movie>> GetMovies(IProgress<int>? progress = null)
        {
            var list = new List<Movie>();

            string html = await http.GetStringAsync(URL);
            var doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(html);

            var nodes = doc.DocumentNode.SelectNodes("//a[starts-with(@href,'/chi-tiet-phim')]");
            if (nodes == null) return list;

            int i = 0;
            foreach (var n in nodes)
            {
                i++;
                progress?.Report(i * 100 / nodes.Count);

                string title = n.InnerText.Trim();
                string link = "https://betacinemas.vn" + n.GetAttributeValue("href", "");

                list.Add(new Movie
                {
                    Title = title,
                    DetailUrl = link,
                    PosterUrl = "" 
                });
            }

            return list;
        }
    }
}
