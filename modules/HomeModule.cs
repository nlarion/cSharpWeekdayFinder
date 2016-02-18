using Nancy;
using LeapYearNS.Objects;
using System.Collections.Generic;

namespace LeapYearModuleNS
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ =>
      {
        return View["index.cshtml"];
      };
       Post["/"]= _ =>
       {
        WeekdayFinder newDate = new WeekdayFinder(Request.Form["month"], Request.Form["day"], Request.Form["year"]);
        newDate.NumberOfLeapYears();
        newDate.FindNumberFromDate();
        return View["index.cshtml", newDate.FindDayOfWeek()];
     };
    }
  }
}
