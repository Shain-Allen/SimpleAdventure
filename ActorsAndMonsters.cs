using System;
namespace SimpleAdventure
{
	public class Actor
	{
		public string name { get; private set; }
		public string description { get; private set; }
		public int health { get; private set; }
		public int atk { get; private set; }
		public int def { get; private set; }
		public Weapon weapon { get; private set; }
		public Armor armor { get; private set; }

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

		public override string ToString()
		{
			return base.ToString();
		}
	}

	public class Monster
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

		public override string ToString()
		{
			return base.ToString();
		}
	}
}