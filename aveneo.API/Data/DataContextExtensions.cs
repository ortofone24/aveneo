using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aveneo.API.Models;

namespace aveneo.API.Data
{
    public static class DataContextExtensions
    {
        public static void EnsureDatabaseSeeded(this DataContext context)
        {
            if (!context.BusinessEntities.Any())
            {
                context.AddRange(new BusinessEntity[]
                {
                    new BusinessEntity()
                    {
                        Name = "SampleName1",
                        Street = "SampleStreet1",
                        StreetNumber = 1,
                        PostCode = "11-111",
                        City = "SampleCity1",
                        KRS = "1111111111",
                        NIP = "2222222222",
                        REGON = "333333333"
                    },
                    new BusinessEntity()
                    {
                        Name = "SampleName2",
                        Street = "SampleStreet2",
                        StreetNumber = 2,
                        PostCode = "22-222",
                        City = "SampleCity2",
                        KRS = "4444444444",
                        NIP = "5555555555",
                        REGON = "666666666"
                    },
                    new BusinessEntity()
                    {
                        Name = "SampleName3",
                        Street = "SampleStreet3",
                        StreetNumber = 3,
                        PostCode = "33-333",
                        City = "SampleCity3",
                        KRS = "7777777777",
                        NIP = "8888888888",
                        REGON = "999999999"
                    }
                });
                context.SaveChanges();
                
            }
        }
    }
}
