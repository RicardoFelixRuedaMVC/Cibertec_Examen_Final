using System.Linq;
using WebDeveloper.Model;

namespace WebDeveloper.DataAccess
{
   public class AuthorsDATA : BaseDataAccess<Authors>
    {
        public Authors GetAuthors(int id)
        {

            using (var dbcontext = new WebContextDB())
                return dbcontext.Authors.FirstOrDefault(x => x.au_id == id);

        }
    }
}
