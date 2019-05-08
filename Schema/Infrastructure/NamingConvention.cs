using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schema.Infrastructure
{
    public class NamingConvention
    {
        public static Func<string, string> Pascalize = s => Inflector.Currnet.Pascalize(s);
        public static Func<string, string> Camelize = s => Inflector.Currnet.Camelize(s);
        public static Func<string, string> Snake = s => Inflector.Currnet.SnakeCase(s);
        public static Func<string, string> Scream = s => Inflector.Currnet.UpperSnakeCase(s);
        public static Func<string, string> Pluralize = s => Inflector.Currnet.Pluralize(s);

        private readonly Func<string, string> convention;

        public NamingConvention(Func<string, string> convention)
        {
            this.convention = convention;
        }
        public string Apply(string word)
        {
            return convention(word);
        }
    }
}
