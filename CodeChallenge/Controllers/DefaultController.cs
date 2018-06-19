using CodeChallenge.Helper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeChallenge.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            //return View();
            return View("Index", GetButtonsFromXml());
        }

        /// <summary>
        /// Gathers the names of buttons to include in the program from the buttons.xml file. 
        /// Add the counting logic with razor syntax to _CountView.cshtml for the different buttons.
        /// </summary>
        /// <returns>List of button names from xml file.</returns>
        private List<string> GetButtonsFromXml()
        {
            MyXmlReader myXmlReader = new MyXmlReader();
            List<string> buttons = myXmlReader.GetButtonsFromXml();
            return buttons;
        }

        /// <summary>
        /// Returns the CountView partial view, with the given evt.
        /// </summary>
        /// <param name="evt">the name of an existing event</param>
        /// <returns></returns>
        [HttpPost]
        [Route("GetCountView")]
        public ActionResult GetCountView(string evt)
        {
            return PartialView("_CountView", evt);
        }
    }
}