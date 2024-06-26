using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcDrawer.Models
{
    public class LotteryTicket
    {

        public char Letter { get; set; }
        public int Number1 { get; set; }
        public int Number2 { get; set; }
        public int Number3 { get; set; }
        public int Number4 { get; set; }
        public int SecondNumber1 { get; set; }
        public int SecondNumber2 { get; set; }
        public int SecondNumber3 { get; set; }
        public int SecondNumber4 { get; set; }
        public int SecondNumber5 { get; set; }


        public int GetNumberCount(LotteryTicket checkingTicket)
        {

            var winningNumberArray = new int[4];
            var checkingNumberArray = new int[4];

            winningNumberArray[0] = Number1;
            winningNumberArray[1] = Number2;
            winningNumberArray[2] = Number3;
            winningNumberArray[3] = Number4;

            checkingNumberArray[0] = checkingTicket.Number1;
            checkingNumberArray[1] = checkingTicket.Number2;
            checkingNumberArray[2] = checkingTicket.Number3;
            checkingNumberArray[3] = checkingTicket.Number4;

            int count = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (checkingNumberArray[i] == winningNumberArray[j])
                    {
                        winningNumberArray[j] = -1;
                        count++;
                        break;
                    }
                }
            }

            return count;

        }

        public bool IsSecondWinningAvailable(LotteryTicket checkingTicket)
        {
            if (SecondNumber1 == checkingTicket.SecondNumber1 &&
               SecondNumber2 == checkingTicket.SecondNumber2 &&
               SecondNumber3 == checkingTicket.SecondNumber3 &&
               SecondNumber4 == checkingTicket.SecondNumber4 &&
               SecondNumber5 == checkingTicket.SecondNumber5)
                return true;

            return false;
        }

        public bool IsLetterCorrect(LotteryTicket checkingTicket)
        {
            if (Letter == checkingTicket.Letter)
                return true;

            return false;
        }

        public string checkWinning(LotteryTicket checkingTicket)
        {
            int numberCount = GetNumberCount(checkingTicket);
            bool isLetterCorrect = IsLetterCorrect(checkingTicket);

            if (isLetterCorrect && numberCount == 4)
            {
                return "Super Prize ";
            }
            else if (numberCount == 4)
            {
                return "Rs. 2,000,000 ";
            }
            else if (isLetterCorrect && numberCount == 3)
            {
                return "You Won Rs. 250,000 ";
            }
            else if (numberCount == 3)
            {
                return "You Won Rs. 5,000 ";
            }
            else if (isLetterCorrect && numberCount == 2)
            {
                return "You Won Rs. 2,000 ";
            }
            else if (numberCount == 2)
            {
                return "You Won Rs. 200 ";
            }
            else if (isLetterCorrect && numberCount == 1)
            {
                return "You Won Rs. 200 ";
            }
            else if (numberCount == 1)
            {
                return "You Won Rs. 40 ";
            }
            else if (isLetterCorrect)
            {
                return "You Won Rs. 40 ";
            }
            else
            {
                return "No Win";
            }

        }

        public string CheckFullAmount(LotteryTicket checkingTicket)
        {
            string checkSuperWinning = checkWinning(checkingTicket);

            if (IsSecondWinningAvailable(checkingTicket))
            {
                if (checkSuperWinning == "No Win")
                {
                    return "You Won Rs.100,000 By Lakshapathi";
                }
                else
                    return checkSuperWinning + " & Rs.100,000 By Lakshapathi";
            }
            return checkSuperWinning;

        }
            

    }
}