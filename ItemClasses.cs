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
			name = _Name;
			discription = _Discription;
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
			name = _Name;
			discription = _Discription;
			atk = _Atk;
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
			name = _Name;
			discription = _Discription;
			def = _Def;
		}

		public override string ToString()
		{
			return name;
		}
	}
}