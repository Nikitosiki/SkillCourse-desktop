using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillCourse.DataBaseStructure
{
    public class UserCollection : List<User>
    {
        public new void Add(User user)
        {
            base.Add(user);
        }

        public new void Remove(User user)
        {
            base.Remove(user);
        }
    }
}
