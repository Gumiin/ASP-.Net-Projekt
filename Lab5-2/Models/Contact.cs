using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace Lab5_2.Models
{
    public class Contact
    {
        [HiddenInput]
        public int ID { get; set; }

        [Required(ErrorMessage = "Musisz podać nazwę kontaktu")]
        [MaxLength(15, ErrorMessage = "Nazwa nie może być dłuższa niz 15 znaków")]
        public string Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        [Phone(ErrorMessage = "Numer musi zawierać tylko cyfry!")]
        public string Phone { get; set; }

        [DisplayFormat(DataFormatString = "{0:F2)")]
        public int Rating { get; set; }
    }
}
