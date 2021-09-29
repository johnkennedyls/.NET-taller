using System;

using System.Linq;

using TallerRPC.Data;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using TallerRPC.Pages.Models;

namespace TallerRPC.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new TallerRPCContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<TallerRPCContext>>()))
            {
                // Look for any movies.
                if (context.Account.Any())
                {
                    return;   // DB has been seeded
                }

                context.Account.AddRange(
                    new Account
                    {
                        UserName = "Andres",
                        Password = "andres",
                        FirstName = "Andres Alfonso",
                        LastName = "Martines",
                        BirthDay = DateTime.Parse("1996-3-2"),
                    },

                    new Account
                    {
                        UserName = "Julian23",
                        Password = "Julian",
                        FirstName = "Julian Julian",
                        LastName = "Vargas Llosa",
                        BirthDay = DateTime.Parse("1995-5-5"),
                    },

                    new Account
                    {
                        UserName = "Nimia67",
                        Password = "1967",
                        FirstName = "Nimia",
                        LastName = "Sandoval",
                        BirthDay = DateTime.Parse("1967-6-5"),
                    }
                );
                context.SaveChanges();
            }
        }
    }
}


