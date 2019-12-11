using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PenaP3.Models
{
    public class InvestmentCalc
    {
        int cmpPerYer { set; get; }
        double interest { set; get; }
        double priciple { set; get; }
        int years { set; get; }

        private double futereValue { get; set;}
        //public IActionResult 
        public InvestmentCalc()
        {
            priciple = 100000;
            years = 30;
            interest = .05;
            cmpPerYer = 12;
            Calc();

        }
        public InvestmentCalc(double principle, int years, double interest, int numTimes)
        {
            this.priciple = principle;
            this.years = years;
            this.interest = interest / 100;
            cmpPerYer = numTimes;
            Calc();

        }
        public void Calc()
        {
            double part1 = 1 + (interest / cmpPerYer);
            double part2 = cmpPerYer * years;
            double part3 = Math.Pow(part1, part2);
            double part4 = priciple * part3;
            
            futereValue = part4;
        }           
    }
}
