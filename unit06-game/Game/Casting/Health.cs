namespace Unit06.Game.Casting
{
    public class Health : Actor
    {
        private int health = 100;
        public Health()
        {
            ChangeHealth(0);
        }

        public void ChangeHealth(int health)
        {
            this.health -= health;
            SetText($"Player Health: {this.health}");
        }
    }
}