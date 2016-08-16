using System.Web.Mvc;
using WebDeveloper.DataAccess;
using WebDeveloper.Model;

namespace Cibertec_Examen_Final.Controllers
{
    public class BookAuthorsController : Controller
    {
        // GET: BookAuthors
        // GET: Authors
        private BookAuthorDATA _BookAuthor = new BookAuthorDATA();

        public ActionResult Index()
        {
            var BookAuthor = new BookAuthorDATA();
            return View(BookAuthor.GetList());
        }
        public ActionResult Create()
        {
            return View(new BookAuthor());
        }
        [HttpPost]
        public ActionResult Create(BookAuthor BookAuthor)
        {
            if (ModelState.IsValid)
            {
                _BookAuthor.Add(BookAuthor);
                return RedirectToAction("Index");
            }
            return View();
        }
        public ActionResult Edit(int id,int id_)
        {
            var BookAuthor = _BookAuthor.GetBookAuthor(id,id_);
            if (BookAuthor == null)
                RedirectToAction("Index");

            return View(BookAuthor);

        }
        [HttpPost]
        public ActionResult Edit(BookAuthor BookAuthor)

        {

            if (_BookAuthor.update(BookAuthor) > 0)
                return RedirectToAction("Index");
            return View(BookAuthor);
        }



        public ActionResult Delete(int id,int id_)
        {

            var BookAuthor = _BookAuthor.GetBookAuthor(id,id_);
            if (BookAuthor == null)
                RedirectToAction("Index");

            return View(BookAuthor);
        }
        [HttpPost]
        public ActionResult Delete(BookAuthor BookAuthor)
        {
            if (_BookAuthor.Delete(BookAuthor) > 0)
                return RedirectToAction("Index");

            return View(BookAuthor);
        }
    }
}