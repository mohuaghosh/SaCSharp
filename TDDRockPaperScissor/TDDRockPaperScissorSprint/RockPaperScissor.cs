using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TDDRockPaperScissorSprint
{
    public class RockPaperScissor
    {
        
        public string ChooseWinner(string Player1, string Player2)
        {
            int input1 = ChooseInput(Player1);
         
            switch (input1)
            
            {
                case 1:

                    if (Player2 == "Paper")

                    {

                        return ("It's a Tie");

                    }
                    else if (Player2 == "Rock")

                    {

                        return ("Player1 Wins");

                    }

                    else
                    {
                        return ("Player2 Wins");

                    }

                case 2:

                    if (Player2 == "Rock")

                    {
                        return ("It's a Tie");

                    }
                    else if (Player2 == "Scissors")
                    {
                        return ("Player1 Wins");
                    }

                    else
                    {

                        return ("Player2 Wins");
                    }

                case 3:


                    if (Player2 == "Scissors")

                    {
                        return ("It's a Tie");

                    }
                    else if (Player2 == "Paper")
                    {
                        return ("Player1 Wins");
                    }

                    else
                    {

                        return ("Player2 Wins");
                    }
            }
            return "Invalid Entry";
        }

        public int ChooseInput(string Player1)
        {
            int input = 0;
         if (Player1 == "Paper")
            {
                input = 1;
            }
            else if(Player1 == "Rock")

            {
                input = 2;
            }

            else if(Player1 == "Scissors")
            {
                input = 3;
            }

            return input;
        }
    }
}

