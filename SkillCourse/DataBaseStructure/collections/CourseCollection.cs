using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillCourse.DataBaseStructure
{
    public class CourseCollection : List<Course>
    {
        public new void Add(Course course)
        {
            base.Add(course);
        }

        public new void Remove(Course course)
        {
            base.Remove(course);
        }
    }
}
