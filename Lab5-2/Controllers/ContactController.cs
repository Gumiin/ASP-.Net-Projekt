using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab5_2.Models;

namespace Lab5_2.Controllers
{
    public class ContactController : Controller
    {
        static List<Contact> contacts = new List<Contact>()
        {
            new Contact(){ID = 1, Name = "Tomek", Email = "tom@wsei.edu.pl"},
            new Contact(){ID = 2, Name = "Lukasz", Email = "luk@wsei.edu.pl"},
            new Contact(){ID = 3, Name = "Marek", Email = "mar@wsei.edu.pl"}
        };

        static int index = 4;

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddForm()
        {
            return View();
        }

        //[HttpPost]
        public IActionResult Add(Contact contact)
        {
            if(ModelState.IsValid)
            {
                contact.ID = index++;
                contacts.Add(contact);
                return View("ConfirmContact", contact);
            }
            else
            {
                return View("AddForm");
            }
        }

        public IActionResult List()
        {
            return View(contacts);
        }

        public IActionResult Delete(int id) //TODO pop up z potwierdzeniem usuniecia rekordu
        {
            Contact found = null;
            foreach(var contact in contacts)
            {
                if(contact.ID == id)
                {
                    found = contact;
                    break;
                }
            }
            if(found != null)
            {
                contacts.Remove(found);
            }
            return View("List", contacts);
        }

        public IActionResult Edit(int id)
        {
            Contact found = null;
            foreach (var contact in contacts)
            {
                if (contact.ID == id)
                {
                    found = contact;
                    break;
                }
            }
            if (found != null)
            {
                throw new NotImplementedException();//TODO wywolac widok z formularzem do edycji i przekacac found
            }
            else
            {
                throw new NotImplementedException();//TODO wywolac widok z informacja o braku takiego obiektu
            }
        }
    }
}
