using System;

namespace ShootingDice
{
    // A Player who always roles one higher than the other player
    public class OneHigherPlayer : Player
    {
        public override void Play(Player other)
        {
            // Call roll for "this" object and for the "other" object
            int myRoll = Roll();
            int otherRoll = other.Roll();
            int myRollPlusOne = otherRoll + 1;

            Console.WriteLine($"{Name} rolls a {myRollPlusOne}");
            Console.WriteLine($"{other.Name} rolls a {otherRoll}");
            if (myRollPlusOne > otherRoll)
            {
                Console.WriteLine($"{Name} Wins!");
            }
            else if (myRollPlusOne < otherRoll)
            {
                Console.WriteLine($"{other.Name} Wins!");
            }
            else
            {
                // if the rolls are equal it's a tie
                Console.WriteLine("It's a tie");
            }
        }
    }
}