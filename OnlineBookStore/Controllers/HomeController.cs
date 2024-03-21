using Microsoft.AspNetCore.Mvc;
using OnlineBookStore.Models;
using OnlineBookStore.Models.ViewModels;
using System.Diagnostics;

namespace OnlineBookStore.Controllers
{
    public class HomeController : Controller
    {
        private IBookRepository _bookRepo;

        public HomeController(IBookRepository temp)
        {
            _bookRepo = temp;
        }

        //Retrieving books from the repository, ordering by BookId,skipping items based on the pageNum and pageSize, then taking pageSize items
        public IActionResult Index(int pageNum)
        {
            int pageSize = 10;
            var projectModel = new ProjectListViewModel
            {
                Books = _bookRepo.Books
                    .OrderBy(x => x.BookId)
                    .Skip((pageNum - 1) * pageSize)
                    .Take(pageSize),

            //Pagination to manage and display the data in smaller chunks or 10items per page               
            PaginationInfo = new PaginationInfo
                {
                    CurrentPage = pageNum,
                    ItemsPerPage = pageSize,
                    TotalItems = _bookRepo.Books.Count()

                }
            };
            return View(projectModel);
        }
    }
}
