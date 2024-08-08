abstract class TankAbstract
{
    public int Health { get; private set; }
    public TankAbstract(int health)
    {
        Health = health;
    }
    public void TakeDamage(int damage)
    {
        if (damage > Health)
        {
            Health = 0;
            Console.WriteLine("The tank is destroyed.");
        }
        else
        {
            Health -= damage;
            Console.WriteLine("The tank is damaged!");
        }
    }
    public abstract void Accept(IVisitor visitor);
}