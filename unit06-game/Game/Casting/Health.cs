namespace Unit06.Game.Casting
{
    public class Health : Actor
    {
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