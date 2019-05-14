using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using MySql.Data.MySqlClient;

namespace Sakila.Models
{
    public partial class InventoryInStock
    {
        private readonly SampleDbContext context;
        public InventoryInStock()
        {
            context = new SampleDbContext();
        }
        public InventoryInStock(SampleDbContext context)
        {
            this.context = context;
        }

        public byte? Execute(
            int? pInventoryId
        )
        {
            var p0 = new MySqlParameter("@p_inventory_id",  pInventoryId);

            var affected = context.Database.SqlQuery<byte?>(@"SELECT inventory_in_stock(
                @p_inventory_id)", 

                p0);

            return affected?.FirstOrDefault();
        }
    }
}
