using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillCourse.DataBaseStructure
{
    public class CertificateCollection : List<Certificate>
    {
        public new void Add(Certificate certificate)
        {
            base.Add(certificate);
        }

        public new void Remove(Certificate certificate)
        {
            base.Remove(certificate);
        }
    }
}
