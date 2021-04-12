using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Windows.Forms;
using TMDbLib.Client;
using TMDbLib.Objects.Collections;
using TMDbLib.Objects.General;
using TMDbLib.Objects.Movies;
using TMDbLib.Objects.Search;

namespace API_practice
{
    class Program
    {
        static async System.Threading.Tasks.Task Main(string[] args)
        {
            TMDbClient client = new TMDbClient("e1505e132578f77683ee1878346d1255");

            // 영화 제목 가져오기
            Movie movie = client.GetMovieAsync(120).Result;
            Console.WriteLine($"Movie name : {movie.Title}");
            Console.WriteLine(movie.PosterPath);
            Console.WriteLine(movie.Credits);

            // 영화 제목, 출연, 예고편 가져오기
            Movie movie2 = await client.GetMovieAsync(47964, MovieMethods.Credits | MovieMethods.Videos);
            Console.WriteLine($"Movie title: {movie2.Title}");
            foreach (Cast cast in movie2.Credits.Cast)
                Console.WriteLine($"{cast.Name} - {cast.Character}");
            Console.WriteLine();
            foreach (Video video in movie2.Videos.Results)
                Console.WriteLine($"Trailer: {video.Type} ({video.Site}), {video.Name}");
            Console.WriteLine();

            // 영화 제목 검색
            SearchContainer<SearchMovie> results = client.SearchMovieAsync("the lord of the ring").Result;
            Console.WriteLine($"Got {results.Results.Count:N0} of {results.TotalResults:N0} results");
            foreach (SearchMovie result in results.Results)
                Console.WriteLine(result.Title + " : " + result.Id);
            Console.WriteLine();

            // 영화 콜렉션 검색
            SearchContainer<SearchCollection> collectons = client.SearchCollectionAsync("the lord of the ring").Result;
            Console.WriteLine($"Got {collectons.Results.Count:N0} collections");
            Collection ring = client.GetCollectionAsync(collectons.Results.First().Id).Result;
            Console.WriteLine($"Collection: {ring.Name}");
            Console.WriteLine();
            Console.WriteLine($"Got {ring.Parts.Count:N0} The Lord Of The Ring Movies");
            foreach (SearchMovie part in ring.Parts)
                Console.WriteLine(part.Title);
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
