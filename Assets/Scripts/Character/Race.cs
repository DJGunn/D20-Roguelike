using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Race {
    private string name;
    private string description; 
    private int[] statMods; //array for stat modifiers
    private float experience; //experience multiplier
    private Skill racialSkill; //all races have a racial skill (or skill tree if we later decide that)
	
    public Race()  {
        name = "blank";
        description = "The blank are nothing. They are the void itself, a true tabula rasa.";
        statMods = new int[6] {0, 0, 0, 0, 0, 0};
        experience = 1.0f;
        racialSkill = new Skill();
    }

    public Race(string name, string description, int[] statMods, float experience, Skill racialSkill)  {
        this.name = name;
        this.description = description;
        this.statMods = statMods;
        this.experience = experience;
        this.racialSkill = racialSkill;
    }

    public string Name() {
        return name;
    }

    public string Description() {
        return description;
    }

    public string StatMods() {
        return "STR: " + statMods[0] + "\n" +
            "DEX: " + statMods[1] + "\n" +
            "CON: " + statMods[2] + "\n" +
            "INT: " + statMods[3] + "\n" +
            "WIS: " + statMods[4] + "\n" +
            "CHA: " + statMods[5] + "\n";
    }

    public string Experience() {
        return "Experience Modifier: " + experience.ToString();
    }

    public string RacialSkill() {
        return "Racial Skill: " + racialSkill.Name();
    }
}
