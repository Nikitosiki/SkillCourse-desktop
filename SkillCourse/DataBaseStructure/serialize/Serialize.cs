using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SkillCourse.DataBaseStructure.serialize
{
    public class Serialize
    {
        public static bool SerializeObject<T>(T obj, string fileName)
        {
            try
            {
                var stringJson = JsonSerializer.Serialize(obj);
                File.WriteAllText(fileName + ".json", stringJson);
                return true;
            }
            catch { return false; }
        }
        public static bool DeserializeObject<T>(ref T obj, string fileName)
        {
            try
            {
                if (File.Exists(fileName + ".json"))
                {
                    var stringJson = File.ReadAllText(fileName + ".json");
                    T? deserializeObject = JsonSerializer.Deserialize<T>(stringJson);
                    if (deserializeObject == null)
                    {
                        return false;
                    }
                    obj = deserializeObject;
                    return true;
                }
                return false;
            }
            catch { return false; }
        }

    }
}
