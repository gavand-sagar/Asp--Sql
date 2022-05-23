using System;
using System.Collections.Generic;

namespace Asp__Sql.Entities
{
    public partial class Class
    {
        public Class()
        {
            Students = new HashSet<Student>();
        }

        public int Id { get; set; }
        public string? ClassName { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}
