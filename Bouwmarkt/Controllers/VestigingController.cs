using Bouwmarkt.Data;
using Bouwmarkt.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bouwmarkt.Controllers
{
    public class VestigingController : Controller
    {
        private readonly ApplicationDbContext _db;

        public VestigingController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Vestiging> objVestigingList = _db.Vestigingen;
            return View(objVestigingList);
        }

        // GET: Vestiging
        public IActionResult Create()
        {
            return View();
        }

        // POST: Vestiging/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Vestiging obj)
        {
            if (ModelState.IsValid)
            {
                _db.Vestigingen.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }




        // GET: Vestiging/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var vestigingVanDb = _db.Vestigingen.Find(id);

            if (vestigingVanDb == null)
            {
                return NotFound();
            }
            return View(vestigingVanDb);
        }

        // POST: Vestiging/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Vestiging obj)
        {
            if (ModelState.IsValid)
            {
                _db.Vestigingen.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }




        // GET: Vestigings/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var vestigingVanDb = _db.Vestigingen.Find(id);

            if (vestigingVanDb == null)
            {
                return NotFound();
            }
            return View(vestigingVanDb);
        }

        // POST: Vestiging/Delete/5
        [HttpPost,ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePOST(int? id)
        {
            var obj = _db.Vestigingen.Find(id);
            if(obj == null)
            {
                return NotFound();
            }

            _db.Vestigingen.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

