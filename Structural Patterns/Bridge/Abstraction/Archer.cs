class Archer : CharacterAbstract
{
	public Archer(IWeapon weapon) : base(weapon) { }
	public override void Attack()
	{
		Console.WriteLine($"The archer is {base._Weapon.UseWeapon()}");
	}
}