using NUnit.Framework;
using System;
using TDDRockPaperScissorSprint;

namespace TDDRockPaperScissor.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

      // Test Case 1 for both Players Choose Paper

        [Test]
        public void ShouldReturnTieWhenBothPlayersArePapers()
        {
            
            RockPaperScissor rockpaperscissor = new RockPaperScissor();
            string result = rockpaperscissor.ChooseWinner("Paper","Paper");
            Assert.AreEqual("It's a Tie",result);
           
        }

        // Test Case 2 for Player1 as Winner when Player1 chooses Paper and Player2 chooses Rock

        [Test]
        public void ShouldReturnPlayer1AsWinnerWhenPlayer1ChoosePaperAndPlayer2ChooseRock()
        {
            
            RockPaperScissor rockpaperscissor = new RockPaperScissor();
            string result = rockpaperscissor.ChooseWinner("Paper","Rock");
            Assert.AreEqual("Player1 Wins",result);
          
        }

        // Test Case 3 for Player2 as Winner when Player1 chooses Paper and Player2 chooses Scissors

        [Test]
        public void ShouldReturnPlayer2AsWinnerWhenPlayer1ChoosePaperAndPlayer2ChooseScissors()
        {
            
            RockPaperScissor rockpaperscissor = new RockPaperScissor();
            string result = rockpaperscissor.ChooseWinner("Paper","Scissors");
            Assert.AreEqual("Player2 Wins",result);
           
        }

         // Test Case 4 for Player1 as Winner when Player1 chooses Rock and Player2 chooses Scissors

        [Test]
        public void ShouldReturnPlayer1AsWinnerWhenPlayer1ChooseRockAndPlayer2ChooseScissors()
        {
            
            RockPaperScissor rockpaperscissor = new RockPaperScissor();
            string result = rockpaperscissor.ChooseWinner("Rock","Scissors");
            Assert.AreEqual("Player1 Wins",result);
           
        }

        // Test Case 5 for Player2 as Winner when Player1 chooses Rock and Player2 chooses Paper

        [Test]
        public void ShouldReturnPlayer2AsWinnerWhenPlayer1ChooseRockAndPlayer2ChoosePaper()
        {
            
            RockPaperScissor rockpaperscissor = new RockPaperScissor();
            string result = rockpaperscissor.ChooseWinner("Rock","Paper");
            Assert.AreEqual("Player2 Wins",result);
           
        }

        // Test Case 6 for Player1 as Winner when Player1 chooses Scissors and Player2 chooses Paper

         [Test]
        public void ShouldReturnPlayer1AsWinnerWhenPlayer1ChooseScissorsAndPlayer2ChoosePaper()
        {
            
            RockPaperScissor rockpaperscissor = new RockPaperScissor();
            string result = rockpaperscissor.ChooseWinner("Scissors","Paper");
            Assert.AreEqual("Player1 Wins",result);
           
        }
        
         // Test Case 7 for Player2 as Winner when Player1 chooses Scissors and Player2 chooses Rock
        
         [Test]
        public void ShouldReturnPlayer2AsWinnerWhenPlayer1ChooseScissorsAndPlayer2ChooseRock()
        {
            
            RockPaperScissor rockpaperscissor = new RockPaperScissor();
            string result = rockpaperscissor.ChooseWinner("Scissors","Rock");
            Assert.AreEqual("Player2 Wins",result);
           
        }

         // Test Case 8 for both Players Choose Rock

        [Test]
        public void ShouldReturnTieWhenBothPlayersAreRock()
        {
            
            RockPaperScissor rockpaperscissor = new RockPaperScissor();
            string result = rockpaperscissor.ChooseWinner("Rock","Rock");
            Assert.AreEqual("It's a Tie",result);
           
        }
        
         // Test Case 9 for both Players Choose Scissors

        [Test]
        public void ShouldReturnTieWhenBothPlayersAreScissors()
        {
            
            RockPaperScissor rockpaperscissor = new RockPaperScissor();
            string result = rockpaperscissor.ChooseWinner("Scissors","Scissors");
            Assert.AreEqual("It's a Tie",result);
           
        }

        // Test Case 10 for an Invalid Entry by a Player

        [Test]
        public void ShouldReturnInvalidEntryMessageWhenanyPlayerEntersInvalidInput()
        {
            
            RockPaperScissor rockpaperscissor = new RockPaperScissor();
            string result = rockpaperscissor.ChooseWinner("ABC","XYZ");
            Assert.AreEqual("Invalid Entry",result);
           
        }

    }
}