using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Schema.Infrastructure
{
    public class Inflector
    {
        private static Inflector inflector;
        public static Inflector Currnet
        {
            get {
                if(inflector == null)
                {
                    inflector = new Inflector();

                }
                return inflector;
            }
        }
        private Dictionary<string, string> PluralIllegular;
        private Dictionary<string, string> PluralRules;
        private Dictionary<string, string> SingularIllegular;
        private Dictionary<string, string> SingularRules;
        private List<string> Uninflected;

        private void InitializeUninflected()
        {
            Uninflected = new List<string>
            {
                "deer",
                "fish",
                "measles",
                "ois",
                "pox",
                "rice",
                "sheep",
                "Amoyese",
                "bison",
                "bream",
                "buffalo",
                "cantus",
                "carp",
                "cod",
                "coitus",
                "corps",
                "diabetes",
                "elk",
                "equipment",
                "flounder",
                "gallows",
                "Genevese",
                "Gilbertese",
                "headquarters",
                "herpes",
                "information",
                "innings",
                "Lucchese",
                "mackerel",
                "mews",
                "moose",
                "mumps",
                "news",
                "nexus",
                "Niasese",
                "Pekingese",
                "Portuguese",
                "proceedings",
                "rabies",
                "salmon",
                "scissors",
                "series",
                "shears",
                "siemens",
                "species",
                "trousers",
                "trout",
                "tuna",
                "whiting",
                "wildebeest",
                "Yengeese"
            };
        }

        private void InitializePluralRules()
        {
            PluralRules = new Dictionary<string, string>();
            PluralRules.Add("(s)tatus$", "$1tatuses");
            PluralRules.Add("^(ox)$", "$1en");
            PluralRules.Add("([m|l])ouse$", "$1ice");
            PluralRules.Add("(matr|vert|ind)ix|ex$", "$1ices");
            PluralRules.Add("(x|ch|ss|sh)$", "$1es");
            PluralRules.Add("(r|t|c)y$", "$1ies");
            PluralRules.Add("(hive)$", "$1s");
            PluralRules.Add("([^f])fe$", "$1ves");
            PluralRules.Add("([lr])f$", "$1ves");
            PluralRules.Add("(.*)sis$", "$1ses");
            PluralRules.Add("([ti])um$", "$1a");
            PluralRules.Add("(buffal|tomat)o$", "$1oes");
            PluralRules.Add("(bu)s$", "$1ses");
            PluralRules.Add("(alias)", "$1es");
            PluralRules.Add("(octop|vir)us$", "$1i");
            PluralRules.Add("(.*)s$", "$1s");
            PluralRules.Add("^(.*)$", "$1s");
            PluralIllegular = new Dictionary<string, string>();
            PluralIllegular.Add("atlas", "atlases");
            PluralIllegular.Add("child", "children");
            PluralIllegular.Add("corpus", "corpuses");
            PluralIllegular.Add("ganglion", "ganglions");
            PluralIllegular.Add("genus", "genera");
            PluralIllegular.Add("graffito", "graffiti");
            PluralIllegular.Add("leaf", "leaves");
            PluralIllegular.Add("man", "men");
            PluralIllegular.Add("money", "monies");
            PluralIllegular.Add("mythos", "mythoi");
            PluralIllegular.Add("numen", "numina");
            PluralIllegular.Add("opus", "opuses");
            PluralIllegular.Add("penis", "penises");
            // i do not need "group" 
            //PluralIllegular.Add("person", "people");
            PluralIllegular.Add("sex", "sexes");
            PluralIllegular.Add("soliloquy", "soliloquies");
            PluralIllegular.Add("testis", "testes");
            PluralIllegular.Add("woman", "women");
            PluralIllegular.Add("move", "moves");
            PluralIllegular.Add("datum", "data");
            PluralIllegular.Add("criterion", "criteria");
        }

        private void InitializeSingularRules()
        {
            SingularRules = new Dictionary<string, string>();
            SingularRules.Add("(s)tatuses$", "$1tatus");
            SingularRules.Add("^(ox)en$", "$1");
            SingularRules.Add("([m|l])ice$", "$1ouse");
            SingularRules.Add("(matr)ices$", "$1ix");
            SingularRules.Add("(vert|ind)ices$", "$1ex");
            SingularRules.Add("(cris|ax|test)es$", "$1is");
            SingularRules.Add("(x|ch|ss|sh)es$", "$1");
            SingularRules.Add("(r|t|c)ies$", "$1y");
            SingularRules.Add("(movie)s$", "$1");
            SingularRules.Add("(hive)s$", "$1");
            SingularRules.Add("([^f])ves$", "$1fe");
            SingularRules.Add("([lr])ves$", "$1f");
            SingularRules.Add("(analy|ba|diagno|parenthe|synop|the)ses$", "$1sis");
            SingularRules.Add("([ti])a$", "$1um");
            SingularRules.Add("(buffal|tomat)oes$", "$1o");
            SingularRules.Add("(bu)ses$", "$1s");
            SingularRules.Add("(alias)es", "$1");
            SingularRules.Add("(octop|vir)i$", "$1us");
            SingularRules.Add("(.*)s$", "$1");
            SingularRules.Add("(.*)", "$1");
            SingularIllegular = new Dictionary<string, string>();
            SingularIllegular.Add("atlases", "atlas");
            SingularIllegular.Add("children", "child");
            SingularIllegular.Add("corpuses", "corpus");
            SingularIllegular.Add("ganglions", "ganglion");
            SingularIllegular.Add("genera", "genus");
            SingularIllegular.Add("graffiti", "graffito");
            SingularIllegular.Add("leaves", "leaf");
            SingularIllegular.Add("men", "man");
            SingularIllegular.Add("monies", "money");
            SingularIllegular.Add("mythoi", "mythos");
            SingularIllegular.Add("numina", "numen");
            SingularIllegular.Add("opuses", "opus");
            SingularIllegular.Add("penises", "penis");
            SingularIllegular.Add("people", "person");
            SingularIllegular.Add("sexes", "sex");
            SingularIllegular.Add("soliloquies", "soliloquy");
            SingularIllegular.Add("testes", "testis");
            SingularIllegular.Add("women", "woman");
            SingularIllegular.Add("moves", "move");
            SingularIllegular.Add("data", "datum");
            SingularIllegular.Add("criteria", "criterion");
        }


        public string Pluralize(string word)
        {
            if (Uninflected == null)
            {
                InitializeUninflected();
            }

            if (PluralRules == null)
            {
                InitializePluralRules();
            }

            if (Uninflected.Any(x => x.ToLower() == word.ToLower()))
            {
                return word;
            }

            foreach (var keyValue in PluralIllegular)
            {
                if (Regex.IsMatch(word, keyValue.Key, RegexOptions.IgnoreCase))
                {
                    return Regex.Replace(word, keyValue.Key, keyValue.Value);
                }
            }

            foreach (var keyValue in PluralRules)
            {
                if (Regex.IsMatch(word, keyValue.Key, RegexOptions.IgnoreCase))
                {
                    var replaced = Regex.Replace(word, keyValue.Key, keyValue.Value);
                    return replaced;
                }
            }

            return word;
        }

        public string Singularize(string word)
        {
            if (Uninflected == null)
            {
                InitializeUninflected();
            }

            if (SingularRules == null)
            {
                InitializeSingularRules();
            }

            if (Uninflected.Any(x => x == word.ToLower()))
            {
                return word;
            }

            foreach (var keyValue in SingularIllegular)
                if (Regex.IsMatch(word, keyValue.Key, RegexOptions.IgnoreCase))
                    return Regex.Replace(word, keyValue.Key, keyValue.Value);

            foreach (var keyValue in SingularRules)
                if (Regex.IsMatch(word, keyValue.Key, RegexOptions.IgnoreCase))
                    return Regex.Replace(word, keyValue.Key, keyValue.Value);

            return word;
        }

        public string Pascalize(string word)
        {
            if (string.IsNullOrEmpty(word))
            {
                return word;
            }

            if (word.Length == 1)
            {
                return word.ToUpper();
            }

            if (word.Contains('_') || word.Contains('-') || word.Contains(' '))
            {
                var pascalized = "";
                var elements = word.Split('_', '-', ' ');
                foreach(var element in elements)
                {
                    if(element.Length == 0)
                    {
                        pascalized += '_';
                    }
                    else
                    {
                        pascalized += NormalizeCamelCase(element, true);
                    }
                }
                return pascalized;
            }

            else
            {
                var pascalized = NormalizeCamelCase(word, true);
                return pascalized;
            }
        }

        public string Camelize(string word)
        {
            if (string.IsNullOrEmpty(word))
            {
                return word;
            }

            if (word.Length == 1)
            {
                return word.ToLower();
            }

            if (word.Contains('_') || word.Contains('-') || word.Contains(' '))
            {
                var pascalized = "";
                var elements = word.Split('_', '-', ' ');
                foreach (var element in elements)
                {
                    if (element.Length == 0)
                    {
                        pascalized += '_';
                    }
                    else
                    {
                        pascalized += NormalizeCamelCase(element, pascalized.Length != 0 );
                    }
                }
                return pascalized;
            }

            else
            {
                var pascalized = NormalizeCamelCase(word, false);
                return pascalized;
            }
        }

        public string SnakeCase(string word)
        {
            var snake = Regex.Replace(word, "([A-Za-z])([0-9]+)", "$1_$2");
            snake = Regex.Replace(snake, "([0-9]+)([A-Za-z])", "$1_$2");
            snake = Regex.Replace(snake, "([A-Z]+)([A-Z][a-z])", "$1_$2");
            snake = Regex.Replace(snake, "([a-z]+)([A-Z])", "$1_$2");
            return snake.ToLower();
        }

        public string UpperSnakeCase(string word)
        {
            return SnakeCase(word).ToUpper();
        }

        private string NormalizeCamelCase(string word, bool upcaseFirst)
        {
            using (TextWriter writer = new StringWriter())
            using (TextReader reader = new StringReader(word))
            {
                var c1 = (char)reader.Read();
                var c2 = '\0';
                var b = true;
                var upcase = upcaseFirst;

                while (reader.Peek() >= 0)
                {
                    c2 = (char)reader.Read();

                    if ('A' <= c1 && c1 <= 'Z')
                    {
                        if ('A' <= c2 && c2 <= 'Z' || '0' <= c2 && c2 <= '9')
                            writer.Write(b && upcase ? c1 : (char)(c1 - 'A' + 'a'));
                        else
                            writer.Write(upcase ? c1 : (char)(c1 - 'A' + 'a'));

                        b = false;
                    }

                    else if ('a' <= c1 && c1 <= 'z')
                    {
                        writer.Write(b && upcase ? (char)(c1 - 'a' + 'A') : c1);

                        if ('A' <= c2 && c2 <= 'Z')
                        {
                            b = true;
                        }
                        else
                        {
                            b = false;
                        }
                    }

                    else
                    {
                        writer.Write(c1);

                        if ('A' <= c2 && c2 <= 'Z' || 'a' <= c2 && c2 <= 'z')
                        {
                            b = true;
                        }
                    }

                    c1 = c2;
                    upcase = true;
                }

                // last
                if ('A' <= c1 && c1 <= 'Z')
                {
                    if ('A' <= c2 && c2 <= 'Z')
                        writer.Write(b && upcase ? c2 : (char)(c2 - 'A' + 'a'));
                    else
                    {
                        writer.Write(c2);
                    }
                }

                else
                {
                    writer.Write(c2);
                }

                var camelized = writer.ToString();
                return camelized;
            }
        }

        private string CamelizeDefault(string word, bool upcaseFirst)
        {
            using (var writer = new StringWriter())
            {
                string baseWord = "";
                if (word.StartsWith("_"))
                {
                    var prefixLength = 0;
                    foreach(var c in word)
                    {
                        if(c == '_')
                        {
                            writer.Write(c);
                            prefixLength++;
                            continue;
                        }
                        break;
                    }
                    baseWord = word.Substring(prefixLength);
                    
                }
                else
                {
                    baseWord = word;
                }
                var isFirst = true;

                foreach (var element in baseWord.Split('_', '-', ' '))
                {
                    if(element.Length == 0)
                    {
                        continue;
                    }
                    writer.Write(upcaseFirst || !isFirst ? element.Substring(0, 1).ToUpper() : element.Substring(0, 1).ToLower());

                    if (element.Length > 1)
                    {
                        writer.Write(element.Substring(1).ToLower());
                    }

                    isFirst = false;
                }

                var camelized = writer.ToString();
                return camelized;
            }
        }
    }
}
