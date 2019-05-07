using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Schema.Infrastructure;

namespace Schema
{
    [Table("TABLES")]
    public class Table
    {
        [Column("TABLE_CATALOG")]
        public string TableCatalog { get; set; }

        [Column("TABLE_SCHEMA")]
        public string TableSchema { get; set; }

        [Column("TABLE_NAME")]
        public string TableName { get; set; }

        [Column("TABLE_TYPE")]
        public string TableType { get; set; }

        public string ObjectName {
            get 
            {
                //return  Inflector.Currnet.Pascalize(TableName);
                return TableName.Replace(" ","_");
            }
        }

        public List<Column> Columns { get; set; }
        public List<Index> Indexes{ get; set; }
        public List<TableConstraint> Constraints{ get; set; }
        public List<ReferentialConstraint> ReferentialConstraints { get; set; }

        public IEnumerable<string> PrimaryKeyColumns
        {
            get {
                foreach (var key in Constraints.Where(x => x.ConstraintType == "PRIMARY KEY"))
                {
                    foreach (var column in key.ConstraintColumns.OrderBy(x => x.OrdinalPosition))
                    {
                        yield return column.ColumnName;
                    }
                }
            }
        }
        public List<ForeignKey> ForeignKeys { get; set; }

        public bool NameEquals(Table table)
        {
            return this.TableSchema == table.TableSchema && this.TableName == table.TableName;
        }
    }
}
