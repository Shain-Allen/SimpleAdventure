using System;
namespace SimpleAdventure
{
	public class Player
	{
		private string name;
		private int health;
		private int def;
		private int atk;
		private Weapon weapon = null;
		private Armor armor = null;
		private Item[] inventory;

		public Player(string _Name, int _Health, int _Def, int _Atk, Weapon _weapon, Armor _Armor, Item[] inventory)
		{

		}
	}
}