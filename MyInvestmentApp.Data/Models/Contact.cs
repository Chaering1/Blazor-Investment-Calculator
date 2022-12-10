using MyInvestmentApp.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyInvestmentApp.Data.Models
{
    public class Contact : IMyCalc
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public bool existingCustomer { get; set; } = false;
        [Required]
        public string emailAddress { get; set; }
        [Required]
        public string phoneNumber { get; set; }
        [Required]
        public string inquiryOptions { get; set; }
        [Required]
        public string userInquiry { get; set; }
        public bool isTesolved { get; set; } = false;
    }
}
