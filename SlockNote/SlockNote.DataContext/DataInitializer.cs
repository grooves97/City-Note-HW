using SlockNote.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlockNote.DataContext
{
    public class DataInitializer : DropCreateDatabaseAlways<DataContext>
    {
        private List<City> cities;
        private List<PhoneNumber> numbers;

        public DataInitializer()
        {
            cities = new List<City>
            {
                new City
                {
                    Name = "Нур-Султан",
                    Code = "+77172"
                },
                new City
                {
                    Name = "Алматы",
                    Code = "+77273"
                },
                new City
                {
                    Name = "Шымкент",
                    Code = "+77252"
                },
                new City
                {
                    Name = "Павлодар",
                    Code = "+77182",
                }
            };
        }

        protected override void Seed(DataContext context)
        {
            context.Cities.AddRange(cities);
            base.Seed(context);
        }
    }
}
