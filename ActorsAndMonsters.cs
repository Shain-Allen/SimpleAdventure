using System;
namespace SimpleAdventure
{
	public class Actor : IComparable
	{
		string name;
		string description;
		int health;
		int atk;
		int def;
		Weapon weapon;
		Armor armor;

		public Actor(string _Name, string _Description, int _Health, int _Atk, int _Def, Weapon _Weapon, Armor _Armor)
		{
			this.name = _Name;
			this.description = _Description;
			this.health = _Health;
			this.atk = _Atk;
			this.def = _Def;
			this.weapon = _Weapon;
			this.armor = _Armor;
		}

		public int CompareTo(Object actor)
		{
			return 0;
		}
	}

	public class Monster : IComparable
	{
		string name;
		string description;
		int health;
		Item loot;
		int atk;
		int def;
		Weapon weapon;
		Armor armor;

		public Monster(string _Name, string _Description, int _Health, Item _Loot, int _Atk, int _Def, Weapon _Weapon, Armor _Armor)
		{
			this.name = _Name;
			this.description = _Description;
			this.health = _Health;
			this.loot = _Loot;
			this.atk = _Atk;
			this.def = _Def;
			this.weapon = _Weapon;
			this.armor = _Armor;
		}

		public int CompareTo(object monster)
		{
			return 0;
		}
	}
}