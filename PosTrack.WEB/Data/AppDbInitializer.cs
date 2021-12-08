using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using PosTrack.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PosTrack.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                if (!context.Tags.Any())
                {
                    context.Tags.AddRange(
                    new Tag()
                    {
                        //Id=1,
                        TagLabel = 1,
                        Rfid = "111111"
                    },
                    new Tag()
                    {
                        //Id=2,
                        TagLabel = 2,
                        Rfid = "222222"
                    },
                    new Tag()
                    {
                        //Id=3,
                        TagLabel = 3,
                        Rfid = "333333"
                    }, new Tag()
                    {
                        //Id=4,
                        TagLabel = 4,
                        Rfid = "444444"
                    }
                    );
                    context.Trolleys.AddRange(
                        new Trolley()
                        {
                           //Id = 1,
                            Label = 1,
                            InService = false,
                            LeftTagID=1,
                            RightTagID=2
                        },
                        new Trolley()
                        {
                            //Id = 2,
                            Label = 2,
                            InService = false,
                            LeftTagID=3,
                            RightTagID=4
                        }

                        );
                    context.SaveChanges();
                }
            }
        }
    }
}
