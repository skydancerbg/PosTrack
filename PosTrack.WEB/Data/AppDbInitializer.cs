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
                    context.Tags.AddRange(new Tag()
                    {
                        TagLabel = 1,
                        Rfid = "111111"
                    },
                    new Tag()
                    {
                        TagLabel = 2,
                        Rfid = "222222"
                    },
                    new Tag()
                    {
                        TagLabel = 3,
                        Rfid = "333333"
                    }, new Tag()
                    {
                        TagLabel = 4,
                        Rfid = "444444"
                    }
                    );
                    context.SaveChanges();
                }
            }
        }
    }
}
