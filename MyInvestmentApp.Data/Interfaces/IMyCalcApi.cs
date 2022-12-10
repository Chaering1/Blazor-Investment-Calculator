using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyInvestmentApp.Data.Models;

namespace MyInvestmentApp.Data.Interfaces
{
    public interface IMyCalcApi
    {
        Task<List<InvestmentCalc>> GetAllInvestmentsAsync();
        Task<InvestmentCalc> GetInvestmentAsync(int Id);
        Task<InvestmentCalc> GetInvestmentForUserAsync(string user);
        Task <InvestmentCalc> SaveInvestmentAsync(InvestmentCalc investment);
        Task DeleteInvestmentCalc(InvestmentCalc investment);
        Task<List<Contact>> GetAllContactsAsync();
        Task<Contact> GetContactAsync(int Id);
        Task<Contact> GetContactForUserAsync(string user);
        Task<Contact> SaveContacttAsync(Contact contact);
        Task DeleteContactCalc(Contact contact);

    }
}
