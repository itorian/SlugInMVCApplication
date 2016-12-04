using System.Collections.Generic;
using System.Linq;

namespace SlugInMVCApplication.Models
{
    public class QuestionExtension
    {
        // moc in-memory records
        public static List<Question> GetQuestion()
        {
            List<Question> question = new List<Question>();

            question.Add(new Question
            {
                Id = 121212,
                Title = "Advanced MVC class with Abhimanyu",
                Slug = "advanced-mvc-class-with-abhimanyu",
                Details = "Details goes here"
            });
            question.Add(new Question
            {
                Id = 121213,
                Title = "Getting started with MVC class with Abhimanyu",
                Slug = "getting-started-with-mvc-class-with-abhimanyu",
                Details = "Details goes here"
            });

            return question;
        }

        // this maybe your database repository
        public static Question GetQuestion(int id)
        {
            var questions = GetQuestion();
            return questions.Where(i => i.Id == id).FirstOrDefault();
        }
    }

    // This maybe your view model or data model
    public class Question
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }
        public string Slug { get; set; }
    }
}