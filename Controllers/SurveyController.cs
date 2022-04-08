using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using DojoSurveyWithModel.Models;

namespace DojoSurveyWithModel.Controllers
{

public class SurveyController : Controller
{
    [HttpGet("")]
    public ViewResult Survey()
    {
        return View("Survey");
    }

    [HttpPost("/process")]
    public IActionResult Process(SurveyModel survey)
    {
        return View("Results", survey);
    }
}

}