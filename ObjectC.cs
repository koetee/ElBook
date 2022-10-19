using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElBook
{
    public class ObjectC
    {
        public static T LoadUsers<T>(string path)
        {
            try {
                string rawJson;
                using (var reader = new StreamReader($"Group\\{path}")) {
                    rawJson = reader.ReadToEnd();
                }

                return JsonConvert.DeserializeObject<T>(rawJson);
            }
            catch (Exception ex) {
                Console.WriteLine(ex.ToString());
                return default(T);
            }
        }

        public static void SaveUsers(string path) => File.WriteAllText($"Group\\{path}", JsonConvert.SerializeObject(MainWindow.users));
    }
}
