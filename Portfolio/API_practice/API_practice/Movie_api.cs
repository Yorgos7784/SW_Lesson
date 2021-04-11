using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TMDbLib.Client;
using TMDbLib.Objects.Movies;

namespace API_practice
{
    class Movie_api
    {
        string api = "e1505e132578f77683ee1878346d1255";


        private string GetHttpLottoString(string strUri)
        {
            string strResponseText = string.Empty;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(strUri);
            request.Method = "GET";

            request.Timeout = 20 * 1000;

            using (HttpWebResponse hwr = (HttpWebResponse)request.GetResponse())
            {
                if (hwr.StatusCode == HttpStatusCode.OK)
                {
                    Stream respStream = hwr.GetResponseStream();
                    using (StreamReader sr = new StreamReader(respStream))
                    {
                        strResponseText = sr.ReadToEnd();
                    }
                }
                else
                {
                    strResponseText = "";
                }
            }
            return strResponseText;
        }

        public void getClient()
        {
            string strReturnValue = GetHttpLottoString("https://api.themoviedb.org/3/movie/550?api_key=e1505e132578f77683ee1878346d1255");
            if (strReturnValue == "")
            {
                MessageBox.Show("불러오기 실패", "오류");
            }

            JsonTextParser jtr = new JsonTextParser();
            JsonObject jo = jtr.Parse(strReturnValue);

            JsonObjectCollection jac = (JsonObjectCollection)jo;

            int[] nums = {
                    Convert.ToInt32(jac["drwtNo1"].GetValue()),
                    Convert.ToInt32(jac["drwtNo2"].GetValue()),
                    Convert.ToInt32(jac["drwtNo3"].GetValue()),
                    Convert.ToInt32(jac["drwtNo4"].GetValue()),
                    Convert.ToInt32(jac["drwtNo5"].GetValue()),
                    Convert.ToInt32(jac["drwtNo6"].GetValue()),
                    Convert.ToInt32(jac["bnusNo"].GetValue())
            };
        }


    }
}
