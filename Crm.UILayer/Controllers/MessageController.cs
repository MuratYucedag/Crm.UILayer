using Crm.BusinessLayer.Abstact;
using Crm.DataAccessLayer.Concrete;
using Crm.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crm.UILayer.Controllers
{
    public class MessageController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IMessageService _messageService;

        public MessageController(UserManager<AppUser> userManager, IMessageService messageService)
        {
            _userManager = userManager;
            _messageService = messageService;
        }

        public async Task<IActionResult> Inbox()
        {
            var mail = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.v = mail.Email;
            var values = _messageService.TGetReceiverMessageList(mail.Email);
            return View(values);
        }
        public async Task<IActionResult> Outbox()
        {
            var mail = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.v = mail.Email;
            var values = _messageService.TGetSenderMessageList(mail.Email);
            return View(values);
        }
        [HttpGet]
        public IActionResult SendMessage()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SendMessage(Message p)
        {
            Context c = new Context();
            var mail = await _userManager.FindByNameAsync(User.Identity.Name);
            p.ReceiverName = c.Users.Where(x => x.Email == p.ReceiverMail).Select(y => y.Name + " " + y.Surname).FirstOrDefault();
            p.SenderName = mail.Name + " " + mail.Surname;
            p.SenderMail = mail.Email;
            p.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            _messageService.TInsert(p);
            return RedirectToAction("Outbox");
        }

        public IActionResult MessageDetails(int id)
        {
            return View();
        }
    }
}
