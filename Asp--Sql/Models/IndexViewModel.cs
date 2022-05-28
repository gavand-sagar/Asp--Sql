using Asp__Sql.Entities;

namespace Asp__Sql.Models
{
    public class IndexViewModel
    {
        public List<GetStudentsResult> Students = new List<GetStudentsResult>();


        public List<Class> classes = new List<Class>();

        public UserInformationViewModel userInfro = new UserInformationViewModel();

        public string Name { get; set; }

        public int ClassId { get; set; }

        public string Heading { get; set; }
    }
}
