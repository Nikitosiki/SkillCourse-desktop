using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillCourse.DataBaseStructure
{
    public class CertificateCollection : List<Certificate>
    {
        private static SkillCourseDB? instanceDB = null;
        private static SkillCourseDB DataBase
        {
            get
            {
                if (instanceDB == null)
                {
                    instanceDB = SkillCourseDB.Instance;
                }
                return instanceDB;
            }
        }


        private bool CheckCorrectObject(Certificate certificate)
        {
            if (DataBase.Courses.Find(course => course.IdCourse == certificate.IdCourse) != null)
                if (DataBase.Users.Students().Find(student => student.IdUser == certificate.IdOwner) != null)
                    if (DataBase.Users.Teathers().Find(teather => teather.IdUser == certificate.IdPresenterTeacher) != null)
                        return true;

            return false;
        }

        private bool CheckCorrectId(Certificate certificate)
        {
            int targetIndex = this.FindIndex(item => item.IdCertificate == certificate.IdCertificate);
            if (targetIndex != -1)
                return true;

            return false;
        }


        public new void Add(Certificate certificate)
        {
            if (CheckCorrectObject(certificate) && CheckCorrectId(certificate))
                base.Add(certificate);
        }

        public new void Remove(Certificate certificate)
        {
            base.Remove(certificate);
        }

        public new void RemoveAll(Predicate<Certificate> match)
        {
            foreach (Certificate certificate in DataBase.Certificates)
            {
                if (match(certificate))
                    this.Remove(certificate);
            }
        }

        public new void RemoveAt(int index)
        {
            Certificate certificate = DataBase.Certificates[index];
            this.Remove(certificate);
        }

        public void Update(Certificate certificate)
        {
            if (!CheckCorrectObject(certificate))
                throw new ArgumentOutOfRangeException(nameof(certificate));

            int objectIndex = DataBase.Certificates.FindIndex(item => item.IdCertificate == certificate.IdCertificate);

            if (objectIndex == -1)
                throw new ArgumentOutOfRangeException(nameof(objectIndex));

            if (DataBase.Certificates[objectIndex] == certificate)
                return;


            DataBase.Certificates[objectIndex] = certificate;
        }

        public new void Clear()
        {
            foreach (Certificate certificate in DataBase.Certificates)
            {
                this.Remove(certificate);
            }
        }




        private new void AddRange(IEnumerable<Course> collection) { throw new NotImplementedException(); }
        private new void Insert(int index, Course item) { throw new NotImplementedException(); }
        private new void InsertRange(int index, IEnumerable<Course> collection) { throw new NotImplementedException(); }
    }
}
