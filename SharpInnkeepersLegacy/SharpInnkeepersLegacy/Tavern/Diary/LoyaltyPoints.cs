using System;
namespace SharpInnkeepersLegacy.Tavern.Diary
{
    class Character
    {
        public int LoyaltyPoints { get; set; }

        public Character(int loyaltyPoints)
        {
            LoyaltyPoints = loyaltyPoints;
        }
    }

    class LoyaltyPoints
    {
        private Character player;

        public LoyaltyPoints()
        {
            player = new Character(100);
        }

        public void DisplayStats()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Очки лояльности: " + player.LoyaltyPoints);
            Console.ResetColor();
        }
    }
}
