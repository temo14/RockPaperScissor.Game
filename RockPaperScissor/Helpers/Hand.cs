namespace RockPaperScissor.Helpers
{
    public class Hand
    {
        public OptionsRPS Selection { get; set; }
        public OptionsRPS WinsAgainst { get; set; }
        public OptionsRPS LossesAgainst { get; set; }
        public string Image { get; set; }

        public GameStatus PlayAgainst(Hand opponentHand)
        {
            if (Selection == opponentHand.Selection)
            {
                return GameStatus.Draw;
            }
            if (LossesAgainst == opponentHand.Selection)
            {
                return GameStatus.Loss;
            }

            return GameStatus.Victory;
        }
    }
}
