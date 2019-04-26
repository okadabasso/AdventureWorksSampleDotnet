﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schema
{
    public class ForeignKey
    {
        public string ConstraintSchema { get; set; }

        public string ConstraintName { get; set; }

        public List<string> Columns { get; set; }

        public List<string> ReferenceColumns { get; set; }

        public Table BaseTable { get; set; }
        public Table ReferencedTable { get; set; }

        public AssociationRole PrincipalRole { get; set; }
        public AssociationRole DependentRole { get; set; }

        public ReferentialConstraint ReferentialConstraint { get; set; }

        public ForeignKey()
        {

        }
        public ForeignKey(TableConstraint constraint, ReferentialConstraint referentialConstraint, Table baseTable, Table referencedTable)
        {
            BaseTable = baseTable;
            ReferencedTable = referencedTable;

            ConstraintSchema = constraint.ConstraintSchema;
            ConstraintName = constraint.ConstraintName;
            Columns = constraint.ConstraintColumns
                    ?.OrderBy(x => x.OrdinalPosition).Select(x => x.ColumnName).ToList()
                    ?? new List<string>();
            ReferenceColumns = referencedTable.Constraints
                    .FirstOrDefault(x => x.ConstraintType == "PRIMARY KEY")
                        ?.ConstraintColumns
                            ?.OrderBy(x => x.OrdinalPosition).Select(x => x.ColumnName).ToList()
                        ?? baseTable.Indexes.FirstOrDefault(x => x.Name == constraint.ConstraintName)
                            ?.Columns.OrderBy(x => x.IndexColumnId).Select(x => x.ColumnName).ToList()
                        ?? new List<string>();

            ReferentialConstraint = referentialConstraint;

            MakeRoles();
        }
        public void MakeRoles()
        {
            // principal role
            // pkey または uniqueに対してのみ外部キーが設定可能
            // 外部キーがnot nullなら主テーブルの存在が必須
            // nullableならnullを設定して主テーブルに存在しないものを表す
            PrincipalRole = new AssociationRole();
            PrincipalRole.RoleName = ReferencedTable.TableName;
            PrincipalRole.Multiplicity = "1";
            PrincipalRole.Required = Columns
                .All(x => BaseTable.Columns.Any(y => y.ColumnName == x && y.IsNullable == "NO")  );

            // dependent role
            // one or many
            // 外部キー列がユニークなら多重度は1
            // 外部キー側が 1件以上必要だとしてもテーブル定義上設定、判定できない
            DependentRole = new AssociationRole();
            DependentRole.RoleName = BaseTable.TableName;
            if (BaseTable.PrimaryKeyColumns.All(x => Columns.Contains(x)))
            {
                DependentRole.Multiplicity = "1";
            }
            else
            {
                DependentRole.Multiplicity = "*";
            }
            DependentRole.Required = false;

        }


    }
}
