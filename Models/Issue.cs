using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab_5_2.Models
{
    public class Issue
    {
        public int ID { get; set; }

        public string Name { get; set; }
        public int Category { get; set; }
    }
}
