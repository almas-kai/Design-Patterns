namespace Bridge;

class Program
{
    static void Main()
    {
        CharacterAbstract character = new Archer(new Bow());
        character.Attack();
        character = new Swordsman(new Sword());
        character.Attack();
    }
}
