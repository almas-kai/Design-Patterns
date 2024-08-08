class LightTank : TankAbstract
{
    public LightTank(int health) : base(health) { }
    public override void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }
}