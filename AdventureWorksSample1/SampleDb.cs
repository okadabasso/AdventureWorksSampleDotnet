using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using Sample.Entities;

namespace AdventureWorksSample1
{
    public class SampleDbContext : DbContext
    {
        public SampleDbContext()
            : base("name=AdventureWorks")
        {
        }
    }
}
