using System.Web.Mvc;
using WebDeveloper.DataAccess;
using WebDeveloper.Model;

namespace Cibertec_Examen_Final.Controllers
{
    public class AuthorsController : Controller
    {
        // GET: Authors
        private AuthorsDATA _Authors = new AuthorsDATA();

        public ActionResult Index()
        {
            var Authors = new AuthorsDATA();
            return View(Authors.GetList());
        }
        public ActionResult Create()
        {
            return View(new Authors());
        }
        [HttpPost]
        public ActionResult Create(Authors Authors)
        {
            if (ModelState.IsValid)
            {
                _Authors.Add(Authors);
                return RedirectToAction("Index");
            }
            return View();
        }
        public ActionResult Edit(int id)
        {
            var Authors = _Authors.GetAuthors(id);
            if (Authors == null)
                RedirectToAction("Index");

            return View(Authors);

        }
        [HttpPost]
        public ActionResult Edit(Authors Authors)

        {

            if (_Authors.update(Authors) > 0)
                return RedirectToAction("Index");
            return View(Authors);
        }



        public ActionResult Delete(int id)
        {

            var Authors = _Authors.GetAuthors(id);
            if (Authors == null)
                RedirectToAction("Index");

            return View(Authors);
        }
        [HttpPost]
        public ActionResult Delete(Authors Authors)
        {
            if (_Authors.Delete(Authors) > 0)
                return RedirectToAction("Index");

            return View(Authors);
        }
    }
}