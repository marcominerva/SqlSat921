using System.Collections.Generic;

namespace SqlSat921.Models.MultipleMappings
{
    public class Restaurant
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Address Address { get; set; }

        public IList<Review> Reviews { get; set; }
    }
}
