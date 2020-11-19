using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuthLibrary.Data;
using AuthLibrary.DomainRpository;
using AuthLibrary.Interface;
using AuthLibrary.Models.BookEntities;
using AuthLibrary.ViewModels;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AuthLibrary.Controllers
{
    public class SubjectsController : Controller
    {
        private readonly IMapper _mapper;
        private readonly AuthLibraryDBContext _context;
        private readonly ISubjectRepository _manager;
        public SubjectsController(IMapper mapper, AuthLibraryDBContext context, ISubjectRepository manager)
        {
            _mapper = mapper;
            _context = context;
            _manager = manager;
        }

        public IActionResult Index()
        {
            var display = _context.Subjects.ToList();
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Index(string searchString)
        {
            try
            {
               // var subjects = from s in _context.Subjects
                             //  select s;

                
               
                //ViewData["NameSortParm"] = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
                ViewData["CurrentFilter"] = searchString;

                //var subjects = from s in _context.Subjects
                //               select s;
                //if (!String.IsNullOrEmpty(searchString))
                //{
                //    subjects = subjects.Where(s => s.Name.ToLower().Contains(searchString.ToLower()));
                //}
                var subjects = await _manager.GetAllWithBooksAsync(searchString);
                //switch (sortOrder)
                //{
                //    case "name_desc":
                //        subjects = subjects.OrderByDescending(s => s.Name);
                //        break;


                //    default:
                //        subjects = subjects.OrderBy(s => s.Name);
                //        break;
                //}
                return View(subjects);


               // var subjectsViewModel = _mapper.Map<IEnumerable<Subject>, IEnumerable<SubjectViewModel>>(subjects);
               // return View(subjectsViewModel);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            

        }
        public async Task<IActionResult>GetSubjectById(int Id)
        {
            try
            {
                var result = await _manager.GetSingleWithBooks(Id);
                if(result != null)
                {
                    //var subjectResult = _mapper.Map<Subject, SubjectViewModel>(result);
                    return View(result);
                }
                return View();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult<SubjectViewModel>> Create(SubjectViewModel subjectView)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    //var subject = _mapper.Map<Subject>(subjectView);
                    var subject = _mapper.Map<SubjectViewModel, Subject>(subjectView);

                    var result = await _context.Subjects.AddAsync(subject);
                    var save = await _context.SaveChangesAsync();

                    // var subject = _mapper.Map<SubjectViewModel, Subject>(subjectView);
                    //var save = _manager.Create(subject);
                    return RedirectToAction("Index");
                    //if (save != null)
                    //{
                    //    return RedirectToAction("Index");
                    //}
                    
                }
                return View();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public IActionResult Edit()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Edit(SubjectViewModel subjectViewModel)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    var subject = _mapper.Map<SubjectViewModel, Subject>(subjectViewModel);
                    //var result = _manager.Edit(subject);
                    var update = _context.Subjects.Update(subject);
                    var save = await _context.SaveChangesAsync();

                    if (update != null)
                    {
                        return RedirectToAction("Index");
                    }
                }
                return View();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        //[HttpPost, ActionName("GetSubjectById")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int Id)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    var result = await _context.Subjects.FindAsync(Id);
                    var delete = _context.Subjects.Remove(result);
                    await _context.SaveChangesAsync();
                    //var result = _manager.Delete(Id);
                    //if (result == null)

                        //return NotFound();
                }
                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
