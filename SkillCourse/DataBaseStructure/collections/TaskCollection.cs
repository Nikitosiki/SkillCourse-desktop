using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillCourse.DataBaseStructure
{
    public class TaskCollection : List<Task>
    {
        public new void Add(Task task)
        {
            base.Add(task);
        }

        public new void Remove(Task task)
        {
            base.Remove(task);
        }
    }
}
