using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using MySql.Data;
using MySql.Data.EntityFramework;
using MySql.Data.MySqlClient;

namespace Sakila.Models
{
    public partial class RewardsReport
    {
        private readonly SampleDbContext context;
        public RewardsReport()
        {
            context = new SampleDbContext();
        }
        public RewardsReport(SampleDbContext context)
        {
            this.context = context;
        }

        ///<summary>execute command rewards_report</summary>
        public int Execute(
            byte? minMonthlyPurchases, 
            decimal? minDollarAmountPurchased, 
            out int? countRewardees
        )
        {
            var p0 = new MySqlParameter("@min_monthly_purchases",  minMonthlyPurchases);
            var p1 = new MySqlParameter("@min_dollar_amount_purchased",  minDollarAmountPurchased);
            var p2 = new MySqlParameter() { ParameterName = "@count_rewardees", Direction = System.Data.ParameterDirection.Output };
            var command = new MySqlCommand(@"rewards_report");
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Connection = context.Database.Connection as MySql.Data.MySqlClient.MySqlConnection;
            command.Parameters.Add(p0);
            command.Parameters.Add(p0);
            command.Parameters.Add(p0);

            var affected = command.ExecuteNonQuery();
            countRewardees = (int?)p2.Value;
            return 0;
        }

    }
}
