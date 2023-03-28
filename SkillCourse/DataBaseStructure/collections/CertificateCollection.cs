using Microsoft.VisualBasic.Devices;
using SkillCourse.DataBaseStructure.serialize;
using SkillCourse.DataBaseStructure.serialize.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillCourse.DataBaseStructure
{
    [Serializable]
    public class CertificateCollection : List<Certificate>, ISerializableJSON
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
            if (targetIndex == -1)
                return true;

            return false;
        }


        public new void Add(Certificate certificate)
        {
            if (CheckCorrectObject(certificate) && CheckCorrectId(certificate))
            {
                base.Add(certificate);
                if (!SerializeObject())
                    throw new ArgumentException("Uncorrect Serialize: " + nameof(DataBase.Certificates));
            }
            else
                throw new Exception("Certificate uncorrect id or object!");
        }

        public new void Remove(Certificate certificate)
        {
            this.RemoveNonSerialized(certificate);

            if (!SerializeObject())
                throw new ArgumentException("Uncorrect Serialize: " + nameof(DataBase.Certificates));
        }

        public new void RemoveAll(Predicate<Certificate> match)
        {
            this.RemoveAllNonSerialized(match);

            if (!SerializeObject())
                throw new ArgumentException("Uncorrect Serialize: " + nameof(DataBase.Certificates));
        }

        public new void RemoveAt(int index) => this.Remove(DataBase.Certificates[index]);

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

            if (!SerializeObject())
                throw new ArgumentException("Uncorrect Serialize: " + nameof(DataBase.Certificates));
        }

        public new void Clear()
        {
            foreach (Certificate certificate in DataBase.Certificates)
            {
                this.RemoveNonSerialized(certificate);
            }

            if (!SerializeObject())
                throw new ArgumentException("Uncorrect Serialize: " + nameof(DataBase.Certificates));
        }


        #region Serialize

        public void RemoveNonSerialized(Certificate certificate)
        {
            base.Remove(certificate);
        }

        public void RemoveAllNonSerialized(Predicate<Certificate> match)
        {
            foreach (Certificate certificate in DataBase.Certificates)
            {
                if (match(certificate))
                    this.RemoveNonSerialized(certificate);
            }
        }

        private bool CheckCorrectPathToDeserialize(string pathFile)
        {
            if (string.IsNullOrEmpty(pathFile))
                return false;

            string serializePathFolder = SerializeSetting.Default.SerializationPath;
            if (!Directory.Exists(serializePathFolder))
                Directory.CreateDirectory(serializePathFolder);

            if (!File.Exists($"{pathFile}.json"))
                return false;

            return true;
        }

        private bool CheckCorrectPathToSerialize(string pathFile)
        {
            if (string.IsNullOrEmpty(pathFile))
                return false;

            string serializePathFolder = SerializeSetting.Default.SerializationPath;
            if (!Directory.Exists(serializePathFolder))
                Directory.CreateDirectory(serializePathFolder);

            return true;
        }


        public bool SerializeObject()
        {
            string path = SerializeSetting.Default.CertificateCollectionSerializationPath;

            if (!CheckCorrectPathToSerialize(path))
                throw new ArgumentException("Uncorrect Path: " + nameof(path));

            if (Serialize.SerializeObject(DataBase.Certificates, path))
                return true;

            return false;
        }

        public bool DeserializeObject()
        {
            string path = SerializeSetting.Default.CertificateCollectionSerializationPath;

            if (!CheckCorrectPathToDeserialize(path))
                throw new ArgumentException("Uncorrect Path: " + nameof(path));

            List<Certificate> newListCertificate = new List<Certificate>();
            if (Serialize.DeserializeObject(ref newListCertificate, path))
            {
                base.Clear();
                base.AddRange(newListCertificate);
                return true;
            }

            return false;
        }

        #endregion

        private new void AddRange(IEnumerable<Course> collection) { throw new NotImplementedException(); }
        private new void Insert(int index, Course item) { throw new NotImplementedException(); }
        private new void InsertRange(int index, IEnumerable<Course> collection) { throw new NotImplementedException(); }
    }
}
