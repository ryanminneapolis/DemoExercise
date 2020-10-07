using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DemoExercise.Models
{
    public class Users
    {

        public int id;
        [Required]
        public string userName;
        public string firstName;
        public string lastName;
        [Required]
        public string emailAddress;
        [Required, DataType(DataType.Password)]
        public string password;
        public DateTime created;
        public DateTime modified;
        public bool isActive;
    }
}
