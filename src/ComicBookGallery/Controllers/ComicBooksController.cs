using ComicBookGallery.Data;
using ComicBookGallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        private ComicBookRepository _comicBookRepository = null;

        public ComicBooksController()
        {
            _comicBookRepository = new ComicBookRepository();
        }

        public ActionResult Index()
        {
            //assign the array of comic books in the GetComicBook method to a variable
            var comicBooks = _comicBookRepository.GetComicBook();

            //then pass the array of comic books to the view, which we're able to do because of the view's model property
            return View(comicBooks);
        }

        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            else
            {
                var comicBook = _comicBookRepository.GetComicBook(id.Value);
                return View(comicBook);
            }
}
    }
}