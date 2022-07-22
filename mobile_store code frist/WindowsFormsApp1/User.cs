using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    class user
    {
        public int Id { get; set; }
        [Required, MinLength(3)]
        public string Name { get; set; }
        [Required]
        public int Phone
        {
            get;
            set;
        }
        [Required]
        public string Password { get; set; }

        public string Confirm_Password { get; set; }
        public string Check_Answer { get; set; }
        public string Answer { get; set; }
        public user(string name, int phone, string pas, string confirm_pass, string chkq, string r)
        {

            Name = name;
            Phone = phone;
            Password = pas;
            Confirm_Password = confirm_pass;
            Check_Answer = chkq;
            Answer = r;
        }
        public user()
        {

        }
    }
}
