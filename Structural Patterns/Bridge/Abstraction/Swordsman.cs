class Swordsman : CharacterAbstract
{
	public Swordsman(IWeapon weapon) : base(weapon) { }
	public override void Attack()
	{
		Console.WriteLine($"The swordsman is {base._Weapon.UseWeapon()}");
	}
}