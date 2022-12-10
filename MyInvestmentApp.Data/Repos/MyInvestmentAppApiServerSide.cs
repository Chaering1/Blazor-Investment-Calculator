using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using MyInvestmentApp.Data.Interfaces;
using MyInvestmentApp.Data.Models;

namespace MyInvestmentApp.Data.Repos
{
    public class MyInvestmentAppApiServerSide : IMyCalcApi
    {
        IDbContextFactory<MyInvestmentAppDBContext> factory;

        public MyInvestmentAppApiServerSide(IDbContextFactory<MyInvestmentAppDBContext> factory)

        {

            this.factory = factory;

        }
        public async Task DeleteContactCalc(Contact contact)
        {
            using var context = factory.CreateDbContext();
            context.Remove(contact);
            await context.SaveChangesAsync();
        }

        public async Task DeleteInvestmentCalc(InvestmentCalc investment)
        {
            using var context = factory.CreateDbContext();
            context.Remove(investment);
            await context.SaveChangesAsync();
        }

        public async Task<List<Contact>> GetAllContactsAsync()
        {
            using var context = factory.CreateDbContext();
            return await context.contacts.ToListAsync();
        }

        public async Task<List<InvestmentCalc>> GetAllInvestmentsAsync()
        {
            using var context = factory.CreateDbContext();
            return await context.investmentCalcs.ToListAsync();
        }

        public async Task<Contact> GetContactAsync(int Id)
        {
            using var context = factory.CreateDbContext();
            return await context.contacts.Where(p => p.Id == Id).FirstOrDefaultAsync();
        }

        public async Task<Contact> GetContactForUserAsync(string user)
        {
            using var context = factory.CreateDbContext();
            return await context.contacts.Where(p => p.Name == user).FirstOrDefaultAsync();
        }

        public async Task<InvestmentCalc> GetInvestmentAsync(int Id)
        {
            using var context = factory.CreateDbContext();
            return await context.investmentCalcs.Where(p => p.Id == Id).FirstOrDefaultAsync();
        }

        public async Task<InvestmentCalc> GetInvestmentForUserAsync(string user)
        {
            using var context = factory.CreateDbContext();
            return await context.investmentCalcs.Where(p => p.whichUser == user).FirstOrDefaultAsync();
        }

        public async Task<Contact> SaveContacttAsync(Contact contact)
        {
            using var context = factory.CreateDbContext();
            if (contact.Id == 0)
            {
                context.Add(contact);
            }
            else
            {
                context.Entry(contact).State = EntityState.Modified;
            }
            await context.SaveChangesAsync();
            return contact;
        }

        public async Task<InvestmentCalc> SaveInvestmentAsync(InvestmentCalc investment)
        {
            using var context = factory.CreateDbContext();
            if (investment.Id == 0)
            {
                context.Add(investment);
            }
            else
            {
                context.Entry(investment).State = EntityState.Modified;
            }
            await context.SaveChangesAsync();
            return investment;
        }
    }
}
