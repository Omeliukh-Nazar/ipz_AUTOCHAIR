﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ipz_Server_AUTOCHAIR
{
    public class User
    {
        public User()
        {

        }
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public User(string name, string email, string phone, string login, string password)
        {
            Name = name;
            Email = email;
            Phone = phone;
            Login = login;
            Password = password;
        }
    }
}
