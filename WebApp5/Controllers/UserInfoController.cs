using WebApp5.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

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
    public IActionResult Privacy()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Index(UserInfo userInfo)
    {
        if (ModelState.IsValid)
        {
            var averageGrade = userInfo.Grades.Average();
            var languagesCount = userInfo.ProgrammingLanguages?.Count ?? 0;

            ViewBag.FullName = $"{userInfo.LastName} {userInfo.FirstName}";
            ViewBag.AverageGrade = averageGrade;
            ViewBag.Languages = userInfo.ProgrammingLanguages ?? new List<string>();
            ViewBag.LanguagesCount = languagesCount;

            return View("Result");
        }
        return View();
    }
}