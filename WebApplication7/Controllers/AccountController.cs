using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication7.Models;

namespace WebApplication7.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            IList<Account> account = new List<Account>();
            account.Add(new Account() { AccountID = 1234, AccountHolderName = "G.Sowjanya", AccountHolderAddress = "Nellore" });
            account.Add(new Account() { AccountID = 4567, AccountHolderName = "G.Sai Krishna", AccountHolderAddress = "Nellore" });
            account.Add(new Account() { AccountID = 8910, AccountHolderName = "G.Rajeswari", AccountHolderAddress = "Nellore" });
            account.Add(new Account() { AccountID = 1112, AccountHolderName = "G.Madhu Kiran", AccountHolderAddress = "Nellore" });
            
            ViewData["account"] = account;

            return View();
        }
    }
}
