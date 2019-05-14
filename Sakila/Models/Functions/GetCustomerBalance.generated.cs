using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using MySql.Data.MySqlClient;

namespace Sakila.Models
{
    public partial class GetCustomerBalance
    {
        private readonly SampleDbContext context;
        public GetCustomerBalance()
        {
            context = new SampleDbContext();
        }
        public GetCustomerBalance(SampleDbContext context)
        {
            this.context = context;
        }

        public decimal? Execute(
            int? pCustomerId, 
            DateTime? pEffectiveDate
        )
        {
            var p0 = new MySqlParameter("@p_customer_id",  pCustomerId);
            var p1 = new MySqlParameter("@p_effective_date",  pEffectiveDate);

            var affected = context.Database.SqlQuery<decimal?>(@"SELECT get_customer_balance(
                @p_customer_id,
                @p_effective_date)", 

                p0, 

                p1);

            return affected?.FirstOrDefault();
        }
    }
}
