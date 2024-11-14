using Form.Models;
using Microsoft.AspNetCore.Mvc;

namespace Form.Controllers
{
    public class StudentController : Controller
    {
        private static List<Student> students = new List<Student>()
        {
            new Student
            {
                StudentId = 1,FullName="Hafeez Basha",Password="Shaik500@#",DateOfBirth=new DateTime(1999,05,01),
                Gender=Gender.Male,Address="Vinayak Nagar Colony",Branch=Branch.CSE,TermsAndConditions=true,
                Hobbies=new List<string>{"Cricket","Table Tennis"},
                Skills=new List<string>{"C#","SQL"}
            },
            new Student
            {
                StudentId = 2,FullName="Kalyani Biryani",Password="Shaik500@#",DateOfBirth=new DateTime(2000,02,18),
                Gender=Gender.Female,Address="Srikakulam",Branch=Branch.ECE,TermsAndConditions=true,
                Hobbies=new List<string>{"Football","Ping Pong"},
                Skills=new List<string>{"Manual Testing","Java"}
            },
            new Student
            {
                StudentId = 3,FullName="Prakash",Password="Shaik500@#",DateOfBirth=new DateTime(1975,03,11),
                Gender=Gender.Male,Address="Ameerpet",Branch=Branch.ECM,TermsAndConditions=true,
                Hobbies=new List<string>{"Walking","Table Tennis"},
                Skills=new List<string>{"C#","WPF","Angular"}
            },
            new Student
            {
                StudentId = 4,FullName="Kiran",Password="Shaik500@#",DateOfBirth=new DateTime(1985,11,21),
                Gender=Gender.Male,Address="Patencheruvu",Branch=Branch.IT,TermsAndConditions=true,
                Hobbies=new List<string>{"Cricket","Table Tennis","Coding"},
                Skills=new List<string>{"C#","SQL","TypeScript","HTML"}
            }
        };

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Registration()
        {
            ViewBag.Hobbies = new List<string> { "Reading", "Traveling", "Music", "Sports", "Photography" };
            ViewBag.Skills = new List<string> { "C#", "Python", "SQL", "Machine Learning", "Physics", "Research", "Data Analysis" };
            return View("registration");
        }

        //Student/GetStudentsList
        public ViewResult GetStudentsList()
        {
            return View("students",students);
        }

        [HttpPost]
        public IActionResult NewStudent(Student student)
        {
            if (ModelState.IsValid)
            {
                student.StudentId = students.Count() + 1;
                students.Add(student);
                return RedirectToAction("GetStudentsList");
            }
            ViewBag.Hobbies = new List<string> { "Reading", "Traveling", "Music", "Sports", "Photography" };
            ViewBag.Skills = new List<string> { "C#", "Python", "SQL", "Machine Learning", "Physics", "Research", "Data Analysis" };

            return View("registration");
        }

        public IActionResult Details(int Id)
        {
            var student = students.ElementAtOrDefault(Id-1);
            if(student == null)
            {
                return NotFound();
            }
            return View(student);
        }
    }
}
