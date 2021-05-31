using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EnrollMent.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EnrollMent.Pages
{
    public class EnrollModel : PageModel
    {
        public EnrollModel(EnrollDBContext enrollDBContext) {
            _enrollmentdbcontext = enrollDBContext;
        }
        private readonly EnrollDBContext _enrollmentdbcontext;
        [BindProperty]
        public Student Student { get; set; }
        public List<Student> Students = new List<Student>();
        public void OnGet(int id)
        {
            Student = _enrollmentdbcontext.Students.FirstOrDefault(Student => Student.StudID == id);
        }
        public ActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                Students = _enrollmentdbcontext.Students.ToList();
                return Page();
            }
                _enrollmentdbcontext.Students.Add(Student);
            _enrollmentdbcontext.SaveChanges();
            return Redirect("/Enroll ");
        }
        public void OnGetDelete(int id)
        {

            var Student = _enrollmentdbcontext.Students.FirstOrDefault(Student => Student.StudID == id);

            if (Student != null)
            {
                _enrollmentdbcontext.Students.Remove(Student);
                _enrollmentdbcontext.SaveChanges();
            }
            

        }
       
    }
}
