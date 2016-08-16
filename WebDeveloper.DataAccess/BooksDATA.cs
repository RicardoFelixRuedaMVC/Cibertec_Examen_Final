using System.Linq;
using WebDeveloper.Model;

namespace WebDeveloper.DataAccess
{
   public class BooksDATA : BaseDataAccess<Books>
    {

        public Books GetBooks(int id)
        {

            using (var dbcontext = new WebContextDB())
                return dbcontext.Books.FirstOrDefault(x => x.title_id == id);

        }
    }
}
