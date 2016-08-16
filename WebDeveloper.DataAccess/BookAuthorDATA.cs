using System.Linq;
using WebDeveloper.Model;
namespace WebDeveloper.DataAccess

{
    public class BookAuthorDATA : BaseDataAccess<BookAuthor>
    {

        public BookAuthor GetBookAuthor(int id, int id_)
        {

            using (var dbcontext = new WebContextDB())
                return dbcontext.BookAuthors.FirstOrDefault(x => x.au_id == id && x.title_id == id_);

        }


    }
}

