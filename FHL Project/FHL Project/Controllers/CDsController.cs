using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FHLProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace FHLProject.Controllers
{
    public class CDsController : Controller
    {
        CDsDBContext db;
        public CDsController(CDsDBContext db)
        {
            this.db = db;
        }

        //pass all Cds list to the AllCDs view
        public IActionResult Search(string searchby, string search)
        {
            if (searchby == "Title")
            {
                return View(db.CDs.Where(x => x.CD_Titles.Contains(search) || search == null));
            }
            else if (searchby == "Place")
            {
                return View(db.CDs.Where(x => x.CD_Place.Contains(search) || search == null));
            }
            else
            {
                return View(db.CDs.Where(x => x.CD_Surname.Contains(search) || search == null));
            }
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}