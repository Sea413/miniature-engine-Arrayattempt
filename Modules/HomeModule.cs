// using Nancy;
// using System.Collections.Generic;
// using System;
//
// namespace FindReplaceNameSpace
// {
//   public class HomeModule : NancyModule
//   {
//     public HomeModule()
//     {
//        Get["/"] = _ =>
//        {
//          return View["gamepage.cshtml"];
//        };
//        Post ["/results"] =_=>
//        {
//         //  string input1 = Request.Form["P1supa"];
//         //  string input2 = Request.Form["P2supa"];
//
//          RPS newRPS = new RPS(Request.Form["player1"], Request.Form["player2"]);
//
//          return View["results.cshtml",  newRPS.GetResult()];
//        };
//
//     }
//   }
// }
