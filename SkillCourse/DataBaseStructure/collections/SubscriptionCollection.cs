using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillCourse.DataBaseStructure
{
    public class SubscriptionCollection : List<SubscriptionCourse>
    {
        public new void Add(SubscriptionCourse subscription)
        {
            base.Add(subscription);
        }

        public new void Remove(SubscriptionCourse subscription)
        {
            base.Remove(subscription);
        }
    }
}
