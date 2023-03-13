﻿using FisherYatesLibrary;
using Microsoft.AspNetCore.Mvc;

namespace FisherYatesWebApp
{
    public class FisherYatesController : Controller
    {
        /// <summary>
        /// todo: Add the skeleton structure for the solution, and implement unit tests (in the FisherYatesTests project)!
        /// </summary>
        /// <param name="input">List of dasherized elements to shuffle (e.g. "D-B-A-C").</param>
        /// <returns>A "200 OK" HTTP response with a content-type of `text/plain; charset=utf-8`. The content should be the dasherized output of the algorithm, e.g. "C-D-A-B".</returns>
        [HttpGet]
        public ActionResult index(string input)
        {
            var result = ModernFisherYatesAlgoritem.Shuffle<string>(input.Split('-'));
            return Content(string.Join(",", result));
        }
    }
}