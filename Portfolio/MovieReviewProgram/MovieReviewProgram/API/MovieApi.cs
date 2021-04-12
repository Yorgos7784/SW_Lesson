using MovieReviewProgram.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using TMDbLib.Client;
using TMDbLib.Objects.General;
using TMDbLib.Objects.Movies;
using TMDbLib.Objects.Search;

namespace MovieReviewProgram.API
{
    class MovieApi
    {
        TMDbClient client;
        //TMDbClient client = new TMDbClient("e1505e132578f77683ee1878346d1255");

        public MovieApi(TMDbClient client)
        {
            this.client = client;
        }

        public List<MovieInfo> searchMovies(string movieName)
        {
            List<MovieInfo> movies = new List<MovieInfo>();
            SearchContainer<SearchMovie> results = client.SearchMovieAsync(movieName).Result;
            Console.WriteLine($"Got {results.Results.Count:N0} of {results.TotalResults:N0} results");
            System.Windows.Forms.MessageBox.Show($"Got {results.Results.Count:N0} of {results.TotalResults:N0} results", "검색 완료");
            foreach (SearchMovie movie in results.Results)
            {
                movies.Add(new MovieInfo(movie.Id, movie.Title, movie.ReleaseDate.ToString()));
            }
            return movies;
        }

    }
}
