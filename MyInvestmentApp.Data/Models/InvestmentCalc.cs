using MyInvestmentApp.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyInvestmentApp.Data.Models
{
    public class InvestmentCalc : IMyCalc
    {
        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Please enter a number between 0 and the maximum 64 bit integer for the principle.")]
        public int principle { get; set; }
        [Required]
        [Range(0, 100, ErrorMessage = "Please enter a number between 0 and 100 for the intrest.")]
        public int intrest { get; set; }
        [Required]
        [Range(1, 30, ErrorMessage = "Please enter a number between 1 and 30 for the years.")]
        public int years { get; set; }
        [Required]
        [Range(1, 24, ErrorMessage = "Please enter a number between 1 and 24 for the compoundsPerYear.")]
        public int compoundsPerYear { get; set; }
        [Required]
        public string whichUser { get; set; }

        public int Id { get; set; }
        public double futureValue { get; set; }

        private double calc()
        {
            futureValue = principle * ((1 + (intrest / compoundsPerYear))
            ^ (compoundsPerYear * years));
            return futureValue;
        }
    }
}
