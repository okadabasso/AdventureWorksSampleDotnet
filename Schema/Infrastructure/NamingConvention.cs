using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schema.Infrastructure
{
    public class NamingConvention
    {
        public readonly static Func<string, string> Pascalize = s => Inflector.Currnet.Pascalize(s);
        public readonly static Func<string, string> Camelize = s => Inflector.Currnet.Camelize(s);
        public readonly static Func<string, string> Snake = s => Inflector.Currnet.SnakeCase(s);
        public readonly static Func<string, string> Scream = s => Inflector.Currnet.UpperSnakeCase(s);
        public readonly static Func<string, string> Pluralize = s => Inflector.Currnet.Pluralize(s);

        private readonly Func<string, string> className;
        private readonly Func<string, string> memberName;
        private readonly Func<string, string> localName;

        public NamingConvention(Func<string, string> classNameConvention, Func<string, string> memberNameConvention, Func<string, string> localNameConvention)
        {
            this.className = classNameConvention;
            this.memberName = memberNameConvention;
            this.localName = localNameConvention;
        }
        public string ClassName(string word)
        {
            return className(word);
        }
        public string MemberName(string word)
        {
            return memberName(word);
        }
        public string LocalName(string word)
        {
            return localName(word);
        }
    }
}
