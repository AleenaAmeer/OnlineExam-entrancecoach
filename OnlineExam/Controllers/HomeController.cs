using OnlineExam.Models;
using OnlineExam.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace OnlineExam.Controllers
{
    public class HomeController : Controller
    {
        private DB db = new DB();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [OutputCache(NoStore = true, Duration = 0, VaryByParam = "None")]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginViewModel loginViewModel)
        {
            if (loginViewModel.UserName == null && loginViewModel.Password == null)
            {
                ModelState.AddModelError("", "Please fill all mandatory fields");
                return View(loginViewModel);
            }

            User user = db.Users.Where(u => u.UserName == loginViewModel.UserName && u.Password == loginViewModel.Password).FirstOrDefault();

            if (user != null)
            {
                var Ticket = new FormsAuthenticationTicket(loginViewModel.UserName, true, 3000);
                string Encrypt = FormsAuthentication.Encrypt(Ticket);
                var Cookie = new HttpCookie(FormsAuthentication.FormsCookieName, Encrypt);
                Cookie.Expires = DateTime.Now.AddHours(3000);
                Cookie.HttpOnly = true;
                Response.Cookies.Add(Cookie);

                if(user.RoleId == 1)
                {
                    return RedirectToAction("Index", "Admin");
                }
                else if(user.RoleId == 2)
                {
                    return RedirectToAction("Index", "Student");
                }
                else if(user.RoleId == 3)
                {
                    return RedirectToAction("Index", "Teacher");
                }
                else if (user.RoleId == 4)
                {
                    return RedirectToAction("Index", "Dtp");
                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }
            }

            ModelState.AddModelError("", "Invalid login attempt.");
            return View(loginViewModel);
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Register(RegisterViewModel model)
        {
            Random random = new Random();
            int unique = random.Next(10000, 99999);
            string alpha = "ECS";
            int ym = DateTime.Now.Year + DateTime.Now.Month;
            var userId = alpha + ym + unique;

            var user = new User
            {
                UserName = model.UserName,
                Email = model.Email,
                FirstName = model.FirstName,
                LastName = model.LastName,
                Password = model.Password,
                UserId = userId,
                CreatedDate = DateTime.Now,
                RoleId = model.RoleId
            };

            var data = db.Users.Where(d => d.Email == user.Email || d.UserName == user.UserName || d.UserId == userId).FirstOrDefault();

            if(data != null)
            {
                ModelState.AddModelError("", "Email or Username already exists");
                return View(model);
            }

            if (ModelState.IsValid)
            {                
                db.Users.Add(user);
                await db.SaveChangesAsync();
                ViewBag.StatusMessage = "Registration Succesfully Completed";
                return RedirectToAction("Login");
            }

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [OutputCache(NoStore = true, Duration = 0, VaryByParam = "None")]
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }

        public ActionResult NotFound()
        {
            return View();
        }


        //StudentRegistration

        public ActionResult StudentRegistration()
        {
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> StudentRegistration(StudentRegistrationViewModel model)
        {
            //BASIC REGISTRATION//

            var StudentRegistration = new StudentRegistration
            {
                

                GroupId = model.GroupId,
                BatchId = model.BatchId,
                ExamAttendingYear = model.ExamAttendingYear,
                PreferredDay = model.PreferredDay,
                ApplnDate = model.ApplnDate,
                AcademicYear = model.AcademicYear,
                AdmissionTestDate = model.AdmissionTestDate,
                PreferredTime = model.PreferredTime,
                WhatsappNo = model.WhatsappNo,
                DOB = model.DOB,
                Gender = model.Gender,
                Religion = model.Religion,
                Caste = model.Caste,
                Community = model.Community,
                BloodGroup = model.BloodGroup,
                Nationalty = model.Nationalty,
                PresentAddress = model.PresentAddress,
                Area = model.Area,
                Location = model.Location,
                State = model.State,
                District = model.District,
                Pincode = model.Pincode,
                QuickContNo = model.QuickContNo,
                Photo = model.Photo,
                QuickWhatsApp = model.QuickWhatsApp,
                PgmId = model.PgmId,
                ClassId = model.ClassId,
                CourseId = model.CourseId,
                SubPgmId = model.SubPgmId,
                //---------------- -----------------//

            };
            //PARENT REGISTRATION//

            var StudentParent = new StudentParent()
            {
                FrName = model.FrName,
                FrOcc = model.FrOcc,
                FrMobNo = model.FrMobNo,
                FrMailId = model.FrMailId,
                FrDistrict = model.FrDistrict,
                FrSign = model.FrSign,
                FrState = model.FrState,
                FrWhatsApp = model.FrWhatsApp,

                MrName = model.MrName,
                MrOcc = model.MrOcc,
                MrMobNo = model.MrMobNo,
                MrMailId = model.MrMailId,
                MrDistrict = model.MrDistrict,
                MrSign = model.MrSign,
                MrState = model.MrState,
                MrWhatsApp = model.MrWhatsApp,
            };


            //---------------------//

            //HOME DETAILS//

            var StudentHomeCountryDetails = new StudentHomeCountryDetails()
            {
                Address1=model.Address1,
                Address2=model.Address2,
                AreaHome = model.AreaHome,
                PincodeHome = model.PincodeHome,
                QuickContact=model.QuickContact,
                LocationHome = model.LocationHome,
                StateHome = model.StateHome,
                EmaiId = model.EmaiId,
                QuickHomeWhatsapp = model.QuickHomeWhatsapp,
                
            };

            //---------------------//


            //ACADEMIC//
            var StudentAcademicPerformance = new StudentAcademicPerformance()
            {

                Class=model.Class,
                PassYear=model.PassYear,
                SchoolAddress=model.SchoolAddress,
                RegNo=model.RegNo,
                Board=model.Board,
                PhyMark=model.PhyMark,
                ChemMark=model.ChemMark,
                BiologyMark=model.BiologyMark,
                MathsMark=model.MathsMark,
                PercOfMark=model.PercOfMark,

            };



            //---------------------//

            //PREV ENTRANCE//
            var StudentPreviousEntrance = new StudentPreviousEntrance()
            {
                PrevEntranceExamName = model.PrevEntranceExamName,
                RollNo = model.RollNo,
                AttemptedYear = model.AttemptedYear,
                Mark = model.Mark,
                Rank = model.Rank,
                NoOfAttempts = model.NoOfAttempts,


            };


            //---------------------//
            if (ModelState.IsValid)
            {
                db.StudentRegistrations.Add(StudentRegistration);
                db.StudentParents.Add(StudentParent);
                db.StudentHomeCountryDetails.Add(StudentHomeCountryDetails);
                db.StudentPreviousEntrances.Add(StudentPreviousEntrance);
                db.StudentAcademicPerformances.Add(StudentAcademicPerformance);
             
                await db.SaveChangesAsync();
                ViewBag.StatusMessage = "Registration Succesfully Completed";
             //   return RedirectToAction("Login");
            }

            return View(model);
        }

    }
}