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
                    },
                    new BusinessEntity()
                    {
                        Name = "SampleName4",
                        Street = "SampleStreet4",
                        StreetNumber = 3,
                        PostCode = "32-313",
                        City = "SampleCity3",
                        KRS = "1234567890",
                        NIP = "5555544444",
                        REGON = "987654321"
                    },
                    new BusinessEntity()
                    {
                        Name = "SampleName5",
                        Street = "SampleStreet5",
                        StreetNumber = 3,
                        PostCode = "13-232",
                        City = "SampleCity5",
                        KRS = "1234333890",
                        NIP = "5555563444",
                        REGON = "981244321"
                    },
                    new BusinessEntity()
                    {
                        Name = "SampleName6",
                        Street = "SampleStreet6",
                        StreetNumber = 3,
                        PostCode = "78-943",
                        City = "SampleCity5",
                        KRS = "1234333342",
                        NIP = "2255433444",
                        REGON = "331244321"
                    },
                    new BusinessEntity()
                    {
                        Name = "SampleName7",
                        Street = "SampleStreet7",
                        StreetNumber = 3,
                        PostCode = "73-122",
                        City = "SampleCity7",
                        KRS = "4324341342",
                        NIP = "2255323444",
                        REGON = "551324321"
                    },
                    new BusinessEntity()
                    {
                        Name = "SampleName8",
                        Street = "SampleStreet8",
                        StreetNumber = 3,
                        PostCode = "65-281",
                        City = "SampleCity8",
                        KRS = "4324886342",
                        NIP = "2252123414",
                        REGON = "500824321"
                    }
                });
                context.SaveChanges();

            }
        }
    }
}