// using Nancy;
// using LeapYearNS.Objects;
// using System.Collections.Generic;
//
// namespace ScrabbleModuleNS
// {
//   public class HomeModule : NancyModule
//   {
//     public HomeModule()
//     {
//       Get["/"] = _ =>
//       {
//         return View["index.cshtml"];
//       };
//        Post["/"]= _ =>
//        {
//         Scrabble newPhrase = new Scrabble(Request.Form["phrase"]);
//         newPhrase.Chop();
//         return View["index.cshtml", newPhrase.Loop()];
//      };
//     }
//   }
// }
