using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6
{
    public static class FileHelper
    {
        private static readonly JsonSerializer Serializer;

        static FileHelper()
        {
            Serializer = new JsonSerializer();
        }
        public static void WritePersonToJson(string fileName, Person person)
        {
            using (var fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                using (var sw = new StreamWriter(fs, Encoding.UTF8))
                {
                    using (var jw = new JsonTextWriter(sw))
                    {
                        jw.Formatting = Formatting.Indented;

                        Serializer.Serialize(jw, person);
                    }
                }
            }
        }

        public static Person ReadPersonFromJson(string fileName)
        {
            Person user = null;
            using (var fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                using (var sr = new StreamReader(fs, Encoding.UTF8))
                {
                    using (var jr = new JsonTextReader(sr))
                    {
                        user = Serializer.Deserialize<Person>(jr);
                    }
                }
            }

            return user;
        }

        public static string CreateFileName(Person person) => $"{person.Name}{person.Surname}.json";
    }
}
