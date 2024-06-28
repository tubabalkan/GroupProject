namespace GroupProject.DAL.Entities
{
    public class Comment
    {
        public int CommentId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Yorum { get; set; }
        public string ImageUrl { get; set; }
        public int CourseId { get; set; }
        public Course Courses { get; set; }

    }
}
