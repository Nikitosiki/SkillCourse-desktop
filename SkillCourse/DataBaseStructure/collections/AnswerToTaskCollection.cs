using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillCourse.DataBaseStructure
{
    public class AnswerToTaskCollection : List<AnswerTask>
    {
        public new void Add(AnswerTask answerTask)
        {
            base.Add(answerTask);
        }

        public new void Remove(AnswerTask answerTask)
        {
            base.Remove(answerTask);
        }
    }
}
