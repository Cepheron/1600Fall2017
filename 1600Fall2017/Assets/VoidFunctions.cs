﻿using System.Collections; 
using System.Collections.Generic; 
using UnityEngine; 
 
public class VoidFunctions : MonoBehaviour 
{
   public string[] companions = {"Annah", "Morte", "Dakkon"};
   public string[] Enemies = {"Ghoul", "Skeleton", "Zombie"}; 
   public int[] enemyCount = {1, 2, 2};

   public string[] boostItems = {"Clot Charm", "Adder Charm"};
   public int[] boostCount = {3, 1};

   public string[] newItem = {"Junk", "Dagger", "Blood Fly Charm"};
   public int [] itemCount = {5, 1, 3}; 

   public string[] NPCs = {"Harmonium Officer", "Dustmen", "Zombie Worker"};
   public int[] npcsSpoken = {1, 3, 1};

    public virtual void Start()
    {
        for (int i = 0; i < companions.Length; i++)
        {
            Recruit(companions[i]);
        }

        for (int i = 0; i < Enemies.Length; i++)
        {
            Fight(Enemies[i], enemyCount[i]);
        }
                            
        for (int i = 0; i < boostItems.Length; i++) 
        { 
            Use(boostItems[i], boostCount[i]); 
        } 
		for (int i = 0; i < newItem.Length; i++) 
        { 
            Find(newItem[i], itemCount[i]); 
        } 
		for (int i = 0; i < NPCs.Length; i++) 
        { 
            Speaks(NPCs[i], npcsSpoken[i]); 
        } 
		Travels();
		Quests();
		UpdatesJournal();
		SpeaksToCompanion();
		Sleeps();
    }
	void Recruit(string companion) 
	{
		print(this.name + " recruits " + companion);
	}

	void Fight(string enemy, int amount) 
	{
		print(this.name + " encountered a " + enemy);
        print(this.name + " killed " + amount + " " + enemy);     
	}
	
	void Use(string boost, int amount)
	{
		print(this.name + " grabs a " + boost);
		print(this.name + " uses " + amount);
	}
	
	void Find(string item, int amount)
	{
		print(this.name + " sees a " + item + " on the ground.");
		print(this.name + " picked up " + amount + " " + item);
	}
	void Speaks(string NPC, int amount)
	{
		print(this.name + " gets the attention of a " + NPC);
		print(this.name + " speaks to " + amount + " " + NPC);
	}
	void Travels()
	{
		print(this.name + " travels to a new location.");
	}
	void Quests()
	{
		print(this.name + " has taken on a new quest.");
	}
	void UpdatesJournal()
	{
		print(this.name + " has updated his journal.");
	}
	void SpeaksToCompanion()
	{
		print(this.name + " speaks to a companion");
	}
	void Sleeps()
	{
		print(this.name + " goes to sleep.");
	}
}