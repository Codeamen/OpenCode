using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuthLibrary.Areas.Identity.Data;
using AuthLibrary.Data;
using AuthLibrary.Models.BookEntities;
using AuthLibrary.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using AutoMapper;

namespace AuthLibrary.Controllers
{
    public class AdminController : Controller
    {
        private readonly AuthLibraryDBContext _context;
        private readonly UserManager<AuthLibraryUser> _userManager;
        private readonly IMapper _mapper;
        public AdminController(AuthLibraryDBContext context, IMapper mapper)
        {
            _mapper = mapper;
            _context = context;   
        }
        //[Authorize(Roles="Admin")]
        public IActionResult AdminView()
        {
            return View();
        }

        public async Task<ActionResult> GetUser()
        {
            var result = await _context.Users.FindAsync();

            return View(result);
        }
        public async Task<ActionResult<IEnumerable<Book>>> GetBooks()
        {
            try
            {
                var result = await _context.Books.Include(ba => ba.BookAuthors)
                    .ThenInclude(a => a.Author)
                    .Include(bs => bs.BookSubjects)
                    .ThenInclude(s => s.Subject)
                    .Include(i => i.Issue)
                    .ToListAsync();
                return View(result);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public async Task<IActionResult>AddBook()
        {
            //var bookViewModel = new BookViewModel();
            //bookViewModel.AuthorsItems = _context.Authors.Select(s => new SelectListItem() { Text = s.Name, Value = s.AuthorId.ToString() });
            //bookViewModel.SubjectsItems = _context.Subjects.Select(s => new SelectListItem() { Text = s.Name, Value = s.SubjectId.ToString() });

            //ViewData["authors"] = await _context.Authors.ToListAsync();
            //ViewData["subjects"] = await _context.Subjects.ToListAsync();
            //PopulateSubjectsDropDownList();
            //PopulateAuthorsDropDownList();
            BookViewModel bookViewModel = new BookViewModel();
            //var book = await _context.Books.ToListAsync();
            //var author = await _context.Authors.ToListAsync();
            return View(bookViewModel);
        }
        [HttpPost]
        public async Task<ActionResult>AddBook(BookViewModel book)
        {
            try
            {
                //var bookAuthors = new List<BookAuthor>();
                //var bookSubjects = new List<BookSubject>();
                if (ModelState.IsValid)
                {
                    //Author bookAuthor = _context.Authors.SingleOrDefault(c => c.AuthorId == book.AuthorId);
                    //Subject bookSubject = _context.Subjects.Single(c => c.SubjectId == book.SubjectId);

                    Book newBook =  new Book()
                    {
                        BookId = book.BookId,
                      
                        //BookSubjects = bookSubject,
                        //BookAuthors = bookAuthor,
                        CallNumber = book.CallNumber,
                        Description = book.Description,
                        ISBN = book.ISBN,
                        MaxIssueDays = book.MaxIssueDays,
                        Language = book.Language,
                        Publisher = book.Publisher,
                        Title = book.Title,
                        Issue = book.Issue
                    };

              

                    var result = await _context.Books.AddAsync(newBook);
                    await _context.SaveChangesAsync();

                }
                //PopulateSubjectsDropDownList(book.BookSubjects);
                //PopulateAuthorsDropDownList(book.BookAuthors);


                    //var bookAuthors = new List<BookAuthor>();
                    //var bookSubjects = new List<BookSubject>();


                return RedirectToAction("GetBooks");
            }
               
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public async Task<ActionResult<IEnumerable<Author>>>GetAuthors()
        {
            try
            {
                if(ModelState.IsValid)
                {
                    var result = await _context.Authors.Include(n => n.BookAuthors)
                    .ThenInclude(a => a.Book)
              .ToListAsync();

                    return View(result);
                }
                return View();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public ActionResult AddAuthor()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult>AddAuthor(Author author)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    var addAuthor = new Author()
                    {
                        AuthorId = author.AuthorId,
                        BookAuthors = author.BookAuthors,
                        Name = author.Name
                    };

                    var result = await _context.Authors.AddAsync(addAuthor);
                    var save = await _context.SaveChangesAsync();

                    if(save==1)
                    {
                        return RedirectToAction("GetAuthors"); 
                    }
                }
                return View();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public async Task<IActionResult> AddAuthorBook()
        {
            ViewBag.AuthorId = new SelectList(_context.Authors, "AuthorId", "Name");
            ViewBag.BookId = new SelectList(_context.Books, "BookId", "Title");
            //ViewBag.Books = _context.Books;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddAuthorBook(int AuthorId, int BookId)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    BookAuthor bookAuthor = new BookAuthor();
                    bookAuthor.AuthorId = AuthorId;
                    bookAuthor.BookId = BookId;
                    await _context.BookAuthors.AddAsync(bookAuthor);
                    await _context.SaveChangesAsync();
                    //foreach (int bkId in Books)
                    //{
                    //    BookAuthor bookAuthor = new BookAuthor();
                    //    bookAuthor.AuthorId = AuthorId;
                    //    bookAuthor.BookId = bkId;

                    //    var result = await _context.BookAuthors.AddAsync(bookAuthor);
                    //    var save = await _context.SaveChangesAsync();
                    //    if (save != 0)
                    //    {
                    //        return RedirectToAction("GetAuthors");
                    //    }

                    //}
                    return RedirectToAction("GetAuthors");
                }
                return View();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        private void PopulateSubjectsDropDownList(object selectedDepartment = null)
        {
            var departmentsQuery = from d in _context.Subjects
                                   orderby d.Name
                                   select d;
            ViewBag.SubjectID = new SelectList(departmentsQuery.AsNoTracking(), "SubjectID", "Name",
            selectedDepartment);

            
        }
        private void PopulateAuthorsDropDownList(object selectedDepartment = null)
        {
            var departmentsQuery = from d in _context.Authors
                                   orderby d.Name
                                   select d;
            ViewBag.AuthorID = new SelectList(departmentsQuery.AsNoTracking(), "AuthorID", "Name",
            selectedDepartment);
        }
    }
}
