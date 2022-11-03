using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DataAccessLayer;

namespace Book.API.Controllers
{
    public class BooksController : ApiController
    {
        BookInformationDAL dal = new BookInformationDAL();
        //READ
        public IEnumerable<tblBookInformation> Get()
        {
            return dal.GetAllBooks();
        }
        public tblBookInformation Get(int id)
        {
            return dal.GetBookByID(id);
        }

        //CREATE
        public tblBookInformation Post(tblBookInformation tblBook)
        {
            return dal.CreateBook(tblBook);
        }

        //UPDATE
        public tblBookInformation Put(int id,tblBookInformation tblBook)
        {
            return dal.UpdatetblBookInformation(id,tblBook);
        }

        //DELETE
        public void Delete(int id)
        {
            dal.DeleteetblBookInformation(id);
        }


    }
}
