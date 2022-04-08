using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DojoSurveyWithModel.Models
{

public class SurveyModel
{
    public SurveyModel() {}

    public string Name { get; set; }
    public string DojoLocation { get; set; }
    public string FavoriteLanguage { get; set; }
    public string Comments { get; set; }
}

}