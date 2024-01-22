using GitPractice.Common;

namespace GitPractice.Model
{
    public class Building : BaseModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }
}
