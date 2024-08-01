abstract class CharacterAbstract
{
	private protected IWeapon _Weapon;
	public CharacterAbstract(IWeapon weapon)
	{
		_Weapon = weapon;
	}
	public abstract void Attack();
}