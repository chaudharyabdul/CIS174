using ContactsWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ContactsWebApp.Controllers
{
    public class ContactController : Controller
    {
        private readonly ContactsContext _context;

        public ContactController(ContactsContext context)
        {
            _context = context;
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Contact contact)
        {
            if (ModelState.IsValid)
            {
                _context.Contacts.Add(contact);
                _context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            return View(contact);
        }

        public IActionResult Delete(int id)
        {
            var contact = _context.Contacts.FirstOrDefault(c => c.Id == id);
            if (contact != null)
            {
                _context.Contacts.Remove(contact);
                _context.SaveChanges();
            }
            return RedirectToAction("Index", "Home");
        }
        public IActionResult Edit(int id)
        {
            var contact = _context.Contacts.Find(id);
            if (contact == null)
            {
                return NotFound();
            }
            return View(contact);
        }

        [HttpPost]
        public IActionResult Edit(int id, Contact contact)
        {
            if (ModelState.IsValid)
            {
                _context.Update(contact);
                _context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            return View(contact);
        }
    }
}