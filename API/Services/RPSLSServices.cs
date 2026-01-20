using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Services
{
    public class RPSLSServices
    {
      public string RandomChoice(string userinput)
        { string [] choices = ["ROCK", "PAPER", "SCISSORS", "LIZARD", "SPOCK"];
            string result = "";
            if (choices.Contains(userinput.ToUpper()))
            {Random rnd = new Random();
            int selection = rnd.Next(0,5);
            string CPU = choices[selection];
            if (userinput.ToUpper() == CPU)
            {result = "It's a tie!";}

    else if (userinput.ToUpper() == "ROCK" && (CPU == "SCISSORS" || CPU == "LIZARD") ||
            (userinput.ToUpper() == "PAPER" && (CPU == "ROCK" || CPU == "SPOCK")) ||
            (userinput.ToUpper() == "SCISSORS" && (CPU == "PAPER" || CPU == "LIZARD")) ||
            (userinput.ToUpper() == "LIZARD" && (CPU == "PAPER" || CPU == "SPOCK")) ||
            (userinput.ToUpper() == "SPOCK" && (CPU == "ROCK" || CPU == "SCISSORS")))
                          {result = "You won! Bazinga!";}
    else {result = "You lost! Better luck next time.";}

            return "You entered... " + userinput.ToUpper() + "! Challenger chose... " + choices[selection] + "! " + result;
            }
            else 
            {return "Please enter only either 'rock', 'paper', 'scissors', 'lizard', or 'spock'.";}
        }
    }
}