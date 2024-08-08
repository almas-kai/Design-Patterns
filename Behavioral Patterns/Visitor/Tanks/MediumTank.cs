class MediumTank : TankAbstract
{
    public MediumTank(int health) : base(health) { }
    public override void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }
}