using System;


namespace SimpleAdventure
{
	class Program
	{
		static void Main(string[] args)
		{
			//items start
			Item silverRing = new Item("Silver Ring", "A Silver Ring from a Goblin");

			//weapons
			Weapon dagger = new Weapon("Dagger", "A dagger is a starting weapon", 3);
			Weapon longSword = new Weapon("Long Sword", "A long sword has better reach then a dagger", 8);

			//armor
			Armor leatherArmor = new Armor("Leather Armor", "Leather armor is the starting armor", 4);
			Armor chainMail = new Armor("Chain Mail", "Chain Mail is better then Leather, thats for sure", 8);
		}
	}
}
