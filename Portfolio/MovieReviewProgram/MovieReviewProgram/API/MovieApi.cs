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
using TMDbLib.Objects.People;
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

        public Bitmap getMoviePoster(int id)
        {
            Movie movie1 = client.GetMovieAsync(id).Result;
            WebClient Downloader = new WebClient();
            Stream ImageStream = Downloader.OpenRead("https://www.themoviedb.org/t/p/w600_and_h900_bestv2" + movie1.PosterPath);
            Bitmap DownloadImage = Bitmap.FromStream(ImageStream) as Bitmap;
            return DownloadImage;
        }
        
        public Bitmap getPersonImage(int id)
        {
            Person person = client.GetPersonAsync(id).Result;
            WebClient Downloader = new WebClient();
            Stream ImageStream = Downloader.OpenRead("https://www.themoviedb.org/t/p/w600_and_h900_bestv2" + person.ProfilePath);
            Bitmap DownloadImage = Bitmap.FromStream(ImageStream) as Bitmap;
            return DownloadImage;
        }
        
        public Bitmap getMovieImage(Movie movie1)
        {
            WebClient Downloader = new WebClient();
            Stream ImageStream = Downloader.OpenRead("https://www.themoviedb.org/t/p/w600_and_h900_bestv2" + movie1.PosterPath);
            Bitmap DownloadImage = Bitmap.FromStream(ImageStream) as Bitmap;
            return DownloadImage;
        }

        public List<PersonInfo> searchPerson(string castName)
        {
            List<PersonInfo> persons = new List<PersonInfo>();
            SearchContainer<SearchPerson> results = client.SearchPersonAsync(castName).Result;
            Console.WriteLine($"Got {results.Results.Count:N0} of {results.TotalResults:N0} results");
            System.Windows.Forms.MessageBox.Show($"Got {results.Results.Count:N0} of {results.TotalResults:N0} results", "검색 완료");
            foreach (SearchPerson person in results.Results)
            {
                persons.Add(new PersonInfo(person.Id, person.Name));
            }
            return persons;
        }

        public async Task<Movie> getMovieAsync(int id)
        {
            return await client.GetMovieAsync(id, MovieMethods.Credits | MovieMethods.Reviews);
        }

        public Person gerPerson(int id)
        {
            return client.GetPersonAsync(id).Result;
        }
    }
}
