using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class User
    {
        public int Id { get; set; }

        public int Boss_id { get; set; }

        public string First_name { get; set; }

        public string Last_name { get; set; }

        public string Username{ get; set; }

        public SecureString Password { get; set; }

        public string Secure_question1 { get; set; }

        public string Secure_question2 { get; set; }

        public SecureString Secure_answer1 { get; set; }

        public SecureString Secure_answer2 { get; set; }
    }
}
