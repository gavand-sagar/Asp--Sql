using System;
using System.Collections.Generic;

namespace Asp__Sql.Entities
{
    public partial class Student
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int? ClassId { get; set; }

        public virtual Class? Class { get; set; }
    }
}
