class HeavyTank : TankAbstract
{
    public HeavyTank(int health) : base(health) { }
    public override void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }
}