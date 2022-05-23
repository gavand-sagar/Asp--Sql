using Asp__Sql.Entities;

namespace Asp__Sql.Models
{
    public class StudentUpdater
    {
        public void UpdateName(Student student,string name)
        {
            student.Name = name;
        }

    }
}
