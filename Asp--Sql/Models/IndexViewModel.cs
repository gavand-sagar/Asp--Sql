using Asp__Sql.Entities;

namespace Asp__Sql.Models
{
    public class IndexViewModel
    {
        public List<GetStudentsResult> Students = new List<GetStudentsResult>();

        public string Heading{ get; set; }
    }
}
