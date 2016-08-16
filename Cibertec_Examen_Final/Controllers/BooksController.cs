using System.Web.Mvc;
using WebDeveloper.DataAccess;
using WebDeveloper.Model;

namespace Cibertec_Examen_Final.Controllers
{
    public class BooksController : Controller
    {
        // GET: Books
        private BooksDATA _Books = new BooksDATA();

        public ActionResult Index()
        {
            var Books = new BooksDATA();
            return View(Books.GetList());
        }
        public ActionResult Create()
        {
            return View(new Books());
        }
        [HttpPost]
        public ActionResult Create(Books Books)
        {
            if (ModelState.IsValid)
            {
                _Books.Add(Books);
                return RedirectToAction("Index");
            }
            return View();
        }
        public ActionResult Edit(int id)
        {
            var Books = _Books.GetBooks(id);
            if (Books == null)
                RedirectToAction("Index");

            return View(Books);

        }
        [HttpPost]
        public ActionResult Edit(Books Books)

        {

            if (_Books.update(Books) > 0)
                return RedirectToAction("Index");
            return View(Books);
        }



        public ActionResult Delete(int id)
        {

            var Books = _Books.GetBooks(id);
            if (Books == null)
                RedirectToAction("Index");

            return View(Books);
        }
        [HttpPost]
        public ActionResult Delete(Books Books)
        {
            if (_Books.Delete(Books) > 0)
                return RedirectToAction("Index");

            return View(Books);
        }
    }
}