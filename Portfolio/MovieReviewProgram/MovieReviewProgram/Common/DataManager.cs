using MovieReviewProgram.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;
using TMDbLib.Objects.Movies;

namespace MovieReviewProgram.Common
{
    class DataManager
    {
        public static List<MovieInfo> movies = new List<MovieInfo>();

        // static이기때문에 DataManager 생성하자마자 메모리에 올라감
        static DataManager()
        {
            Load();
        }

        public static void Load()
        {
            movies.Clear();
            try
            {
                string carsOutput = File.ReadAllText(@"./Movies.xml");
                XElement carXElement = XElement.Parse(carsOutput);
                foreach (var item in carXElement.Descendants("movie"))
                {
                    string tempMovieTitle = item.Element("movieTitle").Value;
                    int tempMovieId = int.Parse(item.Element("movieId").Value);
                    string tempMovieGenre = item.Element("movieGenre").Value;
                    string tempMovieRDate = item.Element("movieRDate").Value;

                    MovieInfo tempMovie = new MovieInfo(tempMovieTitle, tempMovieId, tempMovieGenre, tempMovieRDate);
                    movies.Add(tempMovie);
                }
            }

            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                printLog(ex.Message);
                printLog(ex.StackTrace);

                // 만약 파일이 없어서 진입한 경우
                CreateFile(); // 파일 생성
                Save(); // 파일저장
                Load(); // 다시 불러오기
                // Load함수에 문제가 있을 시 무한루프에 빠진다.
            }
        }

        private static void CreateFile()
        {
            string fileName = @"./Movies.xml";
            StreamWriter writer = File.CreateText(fileName);// 파일이 없으면 해당 파일 생성
            writer.Dispose(); // 메모리 해제
        }

        public static void Save()
        {
            string booksOutput = string.Empty;
            booksOutput += "<movies>\n";
            if (movies.Count > 0)
            {
                foreach (var item in movies)
                {
                    booksOutput += "<movie>\n";
                    booksOutput += $"   <movieTitle>{item.MovieTitle}</movieTitle>\n";
                    booksOutput += $"   <movieId>{item.MovieId}</movieId>\n";
                    booksOutput += $"   <movieGenre>{item.MovieGenre}</movieGenre>\n";
                    booksOutput += $"   <movieRDate>{item.MovieReleaseDate}</movieRDate>\n";
                    booksOutput += "</movie>\n";
                }

            }

            else //xml파일에 아무것도 없는 경우
            {
                booksOutput += "<movie>\n";
                booksOutput += "   <movieTitle>타오르는 여인의 초상</movieTitle>\n";
                booksOutput += "   <movieId>531428</movieId>\n";
                booksOutput += "   <movieGenre>Drama</movieGenre>\n";
                booksOutput += "   <movieRDate>2019-06-17</movieRDate>\n";
                booksOutput += "</movie>\n";
            }
            booksOutput += "</movies>";
            File.WriteAllText(@"./Movies.xml", booksOutput);
        }

        // 두번째 파라미터를 적지 않으면 name에는 parkingHistory가 들어감
        public static void printLog(string contents, string name = "favoriteMovies")
        {
            string directory = "favoriteMovies";
            DirectoryInfo di = new DirectoryInfo(directory);
            if (!di.Exists)
            {
                di.Create(); // 폴더만들기
            }

            // @ : \ 하나 쌉가능 (없으면 \\)
            //using (StreamWriter writer = new StreamWriter(@"parkingHistory\parkingHistory.txt", true))
            using (StreamWriter writer = new StreamWriter(directory + @"\" + name + ".txt", true))
            {
                writer.WriteLine(contents);
            }
        }
    }
}
