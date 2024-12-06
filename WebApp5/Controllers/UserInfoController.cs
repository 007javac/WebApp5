using WebApp5.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;

public class UserInfoController : Controller
{
    private readonly ILogger<UserInfoController> _logger;

    public UserInfoController(ILogger<UserInfoController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Index(UserInfo userInfo)
    {
        if (ModelState.IsValid)
        {
            var averageGrade = userInfo.Grades.Select(g => g.Value).Average();
            var languagesCount = userInfo.ProgrammingLanguages?.Count ?? 0;

            ViewBag.FullName = $"{userInfo.LastName} {userInfo.FirstName}";
            ViewBag.AverageGrade = averageGrade;
            ViewBag.Languages = userInfo.ProgrammingLanguages ?? new List<string>();
            ViewBag.LanguagesCount = languagesCount;

            return View("Result");
        }
        return View(userInfo);
    }
}
