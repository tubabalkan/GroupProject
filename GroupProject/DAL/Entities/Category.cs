using Microsoft.AspNetCore.Mvc.ApplicationModels;

namespace GroupProject.DAL.Entities
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public List<Course> Courses { get; set; }
    }
}
