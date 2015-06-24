using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HelloMaps.Entities;

namespace HelloMaps.Data
{
    public class DataService
    {
        public List<Officer> GetOfficersBySuburb(string suburb)
        {
            var results = new List<Officer>
            {
                new Officer
                {
                    Firstname = "John",
                    Lastname = "Connor",
                    DateOfBirth = new DateTime(1979,8,14)
                },
                new Officer
                {
                    Firstname = "Sarah",
                    Lastname = "Connor",
                    DateOfBirth = new DateTime(1955,11,2)
                }
            };

            return results;
        }

    }
}
