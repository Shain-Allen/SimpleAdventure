using System;
using System.Collections.Generic;

namespace SimpleAdventure
{
	enum dir
	{
		north,
		east,
		south,
		west
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
	}
}