using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using MySql.Data.MySqlClient;

namespace Sakila.Models
{
    public partial class InventoryHeldByCustomer
    {
        private readonly SampleDbContext context;
        public InventoryHeldByCustomer()
        {
            context = new SampleDbContext();
        }
        public InventoryHeldByCustomer(SampleDbContext context)
        {
            this.context = context;
        }

        public int? Execute(
            int? pInventoryId
        )
        {
            var p0 = new MySqlParameter("@p_inventory_id",  pInventoryId);

            var affected = context.Database.SqlQuery<int?>(@"SELECT inventory_held_by_customer(
                @p_inventory_id)", 

                p0);

            return affected?.FirstOrDefault();
        }
    }
}
