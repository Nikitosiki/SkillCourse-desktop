using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillCourse.DataBaseStructure.serialize.interfaces
{
    public interface ISerializableJSON
    {
        public bool SerializeObject(string inFileName);
        public bool DeserializeObject(string fromFileName);
    }
}
