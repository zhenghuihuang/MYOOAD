using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OOAD.Controllers
{
    [Route("")]
    public class InterfaceController : Controller
    {
        [Route("LoginPage")]
        public IActionResult LoginUI()
        {
            return View();
        }

        [Route("ChooseCharacterPage")]
        public ActionResult ChooseCharacter()
        {
            return View();
        }

        [Route("CreateSchoolPage")]
        public ActionResult CreateSchoolUI()
        {
            return View();
        }

        [Route("RegisterPage")]
        public ActionResult RegisterUI()
        {
            return View();
        }

        [Route("StudentBindingPage")]
        public ActionResult StudentBindingUI()
        {
            return View();
        }

        [Route("TeacherBindingPage")]
        public ActionResult TeacherBindingUI()
        {
            return View();
        }

        [Route("StudentRollCallPage")]
        public ActionResult StudentRollCallUI()
        {
            return View();
        }

        [Route("RollStartCallPage")]
        public ActionResult RollStartCallUI()
        {
            return View();
        }

        [Route("RandomGroupChooseTopicPage")]
        public ActionResult RandomGroupChooseTopicUI2()
        {
            return View();
        }

        [Route("RollCallListPage")]
        public ActionResult RollCallListUI()
        {
            return View();
        }

        [Route("ClassManagePage")]
        public ActionResult ClassManageUI()
        {
            return View();
        }

        [Route("GroupInfoPage")]
        public ActionResult GroupInfoUI2()
        {
            return View();
        }

        [Route("StudentMainPage")]
        public ActionResult StudentMainUI()
        {
            return View();
        }

        [Route("SeminarPage")]
        public ActionResult SeminarUI()
        {
            return View();
        }

        [Route("CoursePage")]
        public ActionResult CourseUI()
        {
            return View();
        }

        [Route("CourseInfoPage")]
        public ActionResult CourseInfoUI()
        {
            return View();
        }

        [Route("ChooseSchoolPage")]
        public ActionResult ChooseSchoolUI()
        {
            return View();
        }

        [Route("GrouplistPage")]
        public ActionResult GrouplistUI()
        {
            return View();
        }

        [Route("GradePresentationPage")]
        public ActionResult GradePresentationUI()
        {
            return View();
        }

        [Route("GradePresentationEndPage")]
        public ActionResult GradePresentationEndUI()
        {
            return View();
        }

        [Route("TeacherMainPage")]
        public ActionResult TeacherMainUI()
        {
            return View();
        }

        [Route("CheckTeacherInfoPage")]
        public ActionResult CheckTeacherInfoUI()
        {
            return View();
        }

        [Route("CheckStudentInfoUIPage")]
        public ActionResult CheckStudentInfoUI()
        {
            return View();
        }
    }
}