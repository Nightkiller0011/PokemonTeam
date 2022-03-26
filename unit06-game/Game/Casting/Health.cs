namespace Unit06.Game.Casting
{
    public class Health : Actor
    {
        private int health = 100;
        public Health()
        {
            SetText($"Player Health: " + GetHealth());
        }

        public void ChangeHealth(int health)
        {           
            SetText($"Player Health: " + GetHealth());
        }
    }
}