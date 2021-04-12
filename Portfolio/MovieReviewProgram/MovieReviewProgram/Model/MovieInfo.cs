using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieReviewProgram.Model
{
    class MovieInfo
    {
        private int movieId;
        private string movieTitle;
        private string movieReleaseDate;
        
        public MovieInfo(int movieId, string movieTitle, string movieReleaseDate)
        {
            this.movieId = movieId;
            this.movieTitle = movieTitle;
            this.movieReleaseDate = movieReleaseDate;
        }

        public int MovieId { get => movieId; set => movieId = value; }
        public string MovieTitle { get => movieTitle; set => movieTitle = value; }
        public string MovieReleaseDate { get => movieReleaseDate; set => movieReleaseDate = value; }
    }
}
