using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Schema.Infrastructure;

namespace Schema
{
    public class Association
    {
        public string ConstraintSchema { get; set; }
        public string ConstraintName { get; set; }

        public string UpdateRule { get; set; }
        public string DeleteRule { get; set; }
        public AssociationRole PrincipalRole { get; set; }
        public AssociationRole DependentRole { get; set; }

        public Association()
        {

        }
        public Association(ReferentialConstraint constraint, IEnumerable<KeyColumnUsage> fkeyColumns, IEnumerable<KeyColumnUsage> referencedKeyColumns, IEnumerable<KeyColumnUsage> baseTableKeyColumns)
        {
            ConstraintSchema = constraint.ConstraintSchema;
            ConstraintName = constraint.ConstraintName;
            UpdateRule = constraint.UpdateRule;
            DeleteRule = constraint.DeleteRule;

            BuildPrincipalRole(constraint, fkeyColumns, referencedKeyColumns, baseTableKeyColumns);
            BuildDependentRole(constraint, fkeyColumns, referencedKeyColumns, baseTableKeyColumns);

            BuildReferenceNames(constraint, fkeyColumns, referencedKeyColumns, baseTableKeyColumns);
        }
        private void BuildPrincipalRole(ReferentialConstraint constraint, IEnumerable<KeyColumnUsage> fkeyColumns, IEnumerable<KeyColumnUsage> referencedKeyColumns, IEnumerable<KeyColumnUsage> baseTableKeyColumns)
        {
            // principal role
            // pkey または uniqueに対してのみ外部キーが設定可能
            // 外部キーがnot nullなら主テーブルの存在が必須
            // nullableならnullを設定して主テーブルに存在しないものを表す
            PrincipalRole = new AssociationRole();
            PrincipalRole.RoleName = constraint.ReferenceTableName;
            PrincipalRole.Multiplicity = "1";
            PrincipalRole.Required = fkeyColumns
                .All(x => x.IsNullable == "NO");

            PrincipalRole.Columns = referencedKeyColumns.OrderBy(x => x.OrdinalPosition).Select(x => x.ColumnName).ToList();
        }
        private void BuildDependentRole(ReferentialConstraint constraint, IEnumerable<KeyColumnUsage> fkeyColumns, IEnumerable<KeyColumnUsage> referencedKeyColumns, IEnumerable<KeyColumnUsage> baseTableKeyColumns)
        {
            // dependent role
            // one or many
            // 外部キー列がユニークなら多重度は1
            // 外部キー側が 1件以上必要だとしてもテーブル定義上設定、判定できない
            DependentRole = new AssociationRole();
            DependentRole.RoleName = constraint.BaseTableName;
            if (baseTableKeyColumns.All(x => fkeyColumns.Any(y => y.ColumnName == x.ColumnName)))
            {
                DependentRole.Multiplicity = "1";
            }
            else
            {
                DependentRole.Multiplicity = "*";
            }
            DependentRole.Required = false;

            DependentRole.Columns = fkeyColumns.OrderBy(x => x.OrdinalPosition).Select(x => x.ColumnName).ToList();
        }
        private void BuildReferenceNames(ReferentialConstraint constraint, IEnumerable<KeyColumnUsage> fkeyColumns, IEnumerable<KeyColumnUsage> referencedKeyColumns, IEnumerable<KeyColumnUsage> baseTableKeyColumns)
        {
            var principalRoleName = NamingConvention.Pascalize(PrincipalRole.RoleName);
            var dependentRoleName = NamingConvention.Pascalize(DependentRole.RoleName);

            var prefix = SuggestPrefix(fkeyColumns.First().ColumnName, referencedKeyColumns.First().ColumnName);

            if(prefix == "" || prefix == principalRoleName)
            {
                PrincipalRole.ReferenceName = principalRoleName;
                DependentRole.ReferenceName = dependentRoleName;
            }
            else
            {
                PrincipalRole.ReferenceName = prefix + principalRoleName;
                DependentRole.ReferenceName = prefix + dependentRoleName;
            }

        }
        private string SuggestPrefix(string fkeyColumn, string referencedColumn)
        {
            var primaryNameElements = NamingConvention.Snake(referencedColumn).Split('_');
            var dependentNameElements = NamingConvention.Snake(fkeyColumn).Split('_');

            var diff = new Diff<string>();
            var differences = diff.Calculate(primaryNameElements, dependentNameElements).ToList();
            if (differences.Count == 1 && !differences[0].Modified)
            {
                return "";
            }
            else
            {
                var last = differences.Where(x => x.Modified).LastOrDefault();
                var length = last.ModifiedStart + last.ModifiedLength;

                var prefix = string.Join("", dependentNameElements.Take(length).Select(x => NamingConvention.Pascalize(x)));
                return prefix;
            }

        }
    }
}
