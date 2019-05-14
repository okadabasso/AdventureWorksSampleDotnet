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
    public partial class FilmNotInStock
    {
        private readonly SampleDbContext context;
        public FilmNotInStock()
        {
            context = new SampleDbContext();
        }
        public FilmNotInStock(SampleDbContext context)
        {
            this.context = context;
        }

        ///<summary>execute command film_not_in_stock</summary>
        public int Execute(
            int? pFilmId, 
            int? pStoreId, 
            out int? pFilmCount
        )
        {
            var p0 = new MySqlParameter("@p_film_id",  pFilmId);
            var p1 = new MySqlParameter("@p_store_id",  pStoreId);
            var p2 = new MySqlParameter() { ParameterName = "@p_film_count", Direction = System.Data.ParameterDirection.Output };
            var command = new MySqlCommand(@"film_not_in_stock");
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Connection = context.Database.Connection as MySql.Data.MySqlClient.MySqlConnection;
            command.Parameters.Add(p0);
            command.Parameters.Add(p0);
            command.Parameters.Add(p0);

            var affected = command.ExecuteNonQuery();
            pFilmCount = (int?)p2.Value;
            return 0;
        }

    }
}
