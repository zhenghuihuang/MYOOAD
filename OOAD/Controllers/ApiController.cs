using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OOAD.Models.vo;

namespace OOAD.Controllers
{
    [Route("")]
    [Produces("application/json")]
    public class ApiController : Controller
    {

        [HttpPost("/Login")]
        public IActionResult Login([FromBody]Dlogin my)
        {
            string phone = my.Phone;
            string password = my.Password;
            string temp = "";
            if (phone == "12345" && password == "123")
                temp = "登陆成功";
            else if (phone == "54321" && password == "123")
                temp = "登陆成功";
            else temp = "登陆失败";
            return Json(new { Name = phone, Message = temp });
        }

        [HttpPost("/Register")]
        public IActionResult Register([FromBody]Dregister my)
        {
            string phone = my.Phone;
            string password = my.Password;
            string password_confirm = my.Passwordconfirm;

            string temp = "";
            //if (!password.Equals(password_confirm))
            //    temp = "前后密码不一致";
            if (phone.Length != 11)
                temp = "手机号格式不正确";
            else if (!password.Equals(password_confirm))
                temp = "前后密码不一致";
            else
                temp = "success";
            return Json(new { Message = temp });
        }

        [HttpGet("/school")]
        public IActionResult ChooseSchoolfromcity([FromQuery] string city)
        {

            List<string> temp = new List<string>();
            temp.Add(city + "schoolA");
            temp.Add(city + "schoolB");
            temp.Add(city + "schoolC");
            return Json(temp);
        }

    }
}