using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieReviewProgram.Model
{
    class User
    {
        private string id;
        private string pw;

        public User(string id, string pw)
        {
            this.id = id;
            this.pw = pw;
        }

        public string Id { get => id; set => id = value; }
        public string Pw { get => pw; set => pw = value; }
    }
}
