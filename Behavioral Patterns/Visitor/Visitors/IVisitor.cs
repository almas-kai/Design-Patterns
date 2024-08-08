interface IVisitor
{
    public void Visit(LightTank lightTank);
    public void Visit(MediumTank mediumTank);
    public void Visit(HeavyTank heavyTank);
}