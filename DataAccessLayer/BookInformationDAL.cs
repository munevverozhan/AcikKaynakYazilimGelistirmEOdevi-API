using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class BookInformationDAL
    {
        AcikKaynakAPIEntities db = new AcikKaynakAPIEntities();

        public IEnumerable<tblBookInformation> GetAllBooks()
        {
            return db.tblBookInformations;
        }

        public tblBookInformation GetBookByID(int id)
        {
            return db.tblBookInformations.Find(id);
        }
        public tblBookInformation CreateBook(tblBookInformation tblBook)
        {
            db.tblBookInformations.Add(tblBook);
            db.SaveChanges();
            return tblBook;
        }
        public tblBookInformation UpdatetblBookInformation(int id, tblBookInformation tblBook)
        {
            db.Entry(tblBook).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return tblBook;
        }

        public void DeleteetblBookInformation(int id)
        {
            db.tblBookInformations.Remove(db.tblBookInformations.Find(id));
            db.SaveChanges();
        }

    }

}
