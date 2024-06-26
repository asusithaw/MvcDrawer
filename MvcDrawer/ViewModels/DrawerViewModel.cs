using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcDrawer.ViewModels
{
    public class DrawerViewModel
    {
        public char WinningLetter { get; set; }
        public int WinningNumberOne { get; set; }
        public int WinningNumberTwo { get; set; }
        public int WinningNumberThree { get; set; }
        public int WinningNumberFour { get; set; }
        public int WinningSecondChanceNumberOne { get; set; }
        public int WinningSecondChanceNumberTwo { get; set; }
        public int WinningSecondChanceNumberThree { get; set; }
        public int WinningSecondChanceNumberFour { get; set; }
        public int WinningSecondChanceNumberFive { get; set; }

        public char CheckingLetter { get; set; }
        public int CheckingNumberOne { get; set; }
        public int CheckingNumberTwo { get; set; }
        public int CheckingNumberThree { get; set; }
        public int CheckingNumberFour { get; set; }
        public int CheckingSecondChanceNumberOne { get; set; }
        public int CheckingSecondChanceNumberTwo { get; set; }
        public int CheckingSecondChanceNumberThree { get; set; }
        public int CheckingSecondChanceNumberFour { get; set; }
        public int CheckingSecondChanceNumberFive { get; set; }

        public string Output { get; set; }
    }
}