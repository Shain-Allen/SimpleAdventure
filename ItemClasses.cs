using System;

namespace SimpleAdventure
{
	public class Item : IComparable
	{
		protected string name;
		protected string discription;

		protected Item()
		{
		}

		public Item(string _Name, string _Discription)
		{
			this.name = _Name;
			this.discription = _Discription;
		}

		public int CompareTo(Object item)
		{
			return 0;
		}

		public override string ToString()
		{
			return name;
		}
	}

	public class Weapon : Item
	{
		private int atk;

		public Weapon(string _Name, string _Discription, int _Atk)
		{
			this.name = _Name;
			this.discription = _Discription;
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

		public Armor(string _Name, string _Discription, int _Def)
		{
			this.name = _Name;
			this.discription = _Discription;
			this.def = _Def;
		}

		public override string ToString()
		{
			return name;
		}
	}
}