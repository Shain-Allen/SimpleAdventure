using System;

namespace SimpleAdventure
{
	public class Item
	{
		protected string name;
		protected string description;

		protected Item()
		{
		}

		public Item(string _Name, string _description)
		{
			this.name = _Name;
			this.description = _description;
		}

		public override string ToString()
		{
			return name;
		}
	}

	public class Weapon : Item
	{
		private int atk;

		public Weapon(string _Name, string _description, int _Atk)
		{
			this.name = _Name;
			this.description = _description;
			this.atk = _Atk;
		}

		public override string ToString()
		{
			return name;
		}
	}

	public class Armor : Item
	{
		private int def;

		public Armor(string _Name, string _description, int _Def)
		{
			this.name = _Name;
			this.description = _description;
			this.def = _Def;
		}

		public override string ToString()
		{
			return name;
		}
	}
}