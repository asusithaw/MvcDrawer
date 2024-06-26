using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Text.RegularExpressions;
using MvcDrawer.ViewModels;
using MvcDrawer.Models;

namespace MvcDrawer.Controllers
{
    public class DrawerController : Controller
    {
        //
        // GET: /Drawer/

        public ActionResult Index()
        {
            //var vm = new DrawerViewModel();
            return View();
        }

        [HttpPost]
        public ActionResult Result(DrawerViewModel vm)
        {
            var winningTicket = new LotteryTicket {
                Letter = vm.WinningLetter,
                Number1 = vm.WinningNumberOne,
                Number2 = vm.WinningNumberTwo,
                Number3 = vm.WinningNumberThree,
                Number4 = vm.WinningNumberFour,
                SecondNumber1 = vm.WinningSecondChanceNumberOne,
                SecondNumber2 = vm.WinningSecondChanceNumberTwo,
                SecondNumber3 = vm.WinningSecondChanceNumberThree,
                SecondNumber4 = vm.WinningSecondChanceNumberFour,
                SecondNumber5 = vm.WinningSecondChanceNumberFive
            };

            var checkingTicket = new LotteryTicket
            {
                Letter = vm.CheckingLetter,
                Number1 = vm.CheckingNumberOne,
                Number2 = vm.CheckingNumberTwo,
                Number3 = vm.CheckingNumberThree,
                Number4 = vm.CheckingNumberFour,
                SecondNumber1 = vm.CheckingSecondChanceNumberOne,
                SecondNumber2 = vm.CheckingSecondChanceNumberTwo,
                SecondNumber3 = vm.CheckingSecondChanceNumberThree,
                SecondNumber4 = vm.CheckingSecondChanceNumberFour,
                SecondNumber5 = vm.CheckingSecondChanceNumberFive
            };

            vm.Output = winningTicket.CheckFullAmount(checkingTicket);
            ViewBag.Result = vm.Output;
            return View("Index", vm);
        }

    }
}
