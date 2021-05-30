using System;
using System.Collections.Generic;

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
		private List<Item> inventory = new List<Item>();


		public Player(string _Name, int _Health, int _Def, int _Atk, Weapon _weapon, Armor _Armor, Item[] _Inventory)
		{
			this.name = _Name;
			this.health = _Health;
			this.def = _Def;
			this.atk = _Atk;
			this.weapon = _weapon;
			this.armor = _Armor;
			foreach (Item item in _Inventory)
			{
				this.inventory.Add(item);
			}
		}

		public override string ToString()
		{
			return
			"-----------------------------------------------------\n" +
			$"{this.name}	Health:{this.health}\n" +
			$"Weapon: {this.weapon.ToString()}  Armor: {this.armor.ToString()}\n" +
			"Inventory: " + PrintInv(this.inventory) +
			"\n-----------------------------------------------------";
		}

		public bool EquipBetterItem(Item item, string type)
		{
			type.ToLower();

			if (type == "weapon")
			{
				return true;
			}
			else if (type == "armor")
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		//returns true if item was added and false if item could not be added
		public bool itemToInv(Item item)
		{
			if (item == null)
			{
				return false;
			}

			inventory.Add(item);
			return true;
		}

		public string PrintInv(List<Item> inventory)
		{
			string inv = "";

			foreach (Item item in inventory)
			{
				inv += item.ToString();
			}

			return inv;
		}
	}
}