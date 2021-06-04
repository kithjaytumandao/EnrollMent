using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EnrollMent.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EnrollMent.Pages
{
    public class EditModel : PageModel
    {
        public EditModel(EnrollDBContext enrollDBContext)
        {
            _enrollmentdbcontext = enrollDBContext;

        }
        private readonly EnrollDBContext _enrollmentdbcontext;
        [BindProperty]
        public Student Student { get; set; }
      
        public void OnGet(int id)
        {
            Student = _enrollmentdbcontext.Students.FirstOrDefault(Student => Student.StudID== id);
        }
        public ActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            Student pers = new Student();
            pers = _enrollmentdbcontext.Students.FirstOrDefault(Student => Student.StudID == Student.StudID);
            if (pers != null)
            {
                pers.StudName =Student.StudName;
                pers.StudAge = Student.StudAge;
                pers.StudAddress = Student.StudAddress;
                pers.StudCourse = Student.StudCourse;
                pers.StudSCYear = Student.StudSCYear;
                pers.StudSchool = Student.StudSchool;
                pers.StudStreet = Student.StudStreet;
                pers.StudCity = Student.StudCity;
                _enrollmentdbcontext.Update(pers);
                _enrollmentdbcontext.SaveChanges();
            }
            return Redirect("Enroll");
        }
    }
}
