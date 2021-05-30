using System;
using System.Collections.Generic;

namespace SimpleAdventure
{
	enum dir
	{
		North,
		South,
		East,
		West
	};
	public class Location
	{
		string name;
		Location[] exits = new Location[4];
		List<string> dialogue;
		int dialoguePos = 0;
		List<Actor> actors;
		List<Monster> monsters;
		List<Item> items;

		Location(string _Name, Location[] _Exits, List<string> _Dialogue, int _DialoguePos, List<Actor> _Actors, List<Monster> _Monsters, List<Item> _Items)
		{
			this.name = _Name;
			this.exits = _Exits;
			this.dialogue = _Dialogue;
			this.dialoguePos = _DialoguePos;
			this.actors = _Actors;
			this.monsters = _Monsters;
			this.items = _Items;
		}

		public override string ToString()
		{
			return $"{dialogue[dialoguePos]}\n\n" +
			"";
		}
	}

	class Options
	{

	}
}