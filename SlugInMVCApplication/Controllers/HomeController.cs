using SlugInMVCApplication.Models;
using System.Web.Mvc;

namespace SlugInMVCApplication.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var model = QuestionExtension.GetQuestion();
            return View(model);
        }

        // GET: Home
        public ActionResult Question(int id, string slug)
        {
            // call database table to get question based on input 'id'
            // 'id' is primary key in database table
            // depending on unique slug all the time is not good idea 
            // so, let's keep 'id' primary key and keep it using
            var question = QuestionExtension.GetQuestion(id);

            // check if database returned no question
            if (question == null)
                return Redirect("~/error/noquestion");

            // redirect on slug based url here only
            // or you can create action filter so that it works everywhere in your application
            if (string.IsNullOrEmpty(slug))
            {
                slug = question.Slug;
                return RedirectToRoute("Question_Default", new { id = id, slug = slug });
            }

            return View(question);
        }
    }
}