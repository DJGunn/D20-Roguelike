// Prototype
// We'll implement this using inheritance and polymorphism later
// we'll also want to make a dedicated controller for character creation, that then passes the created character values into a seperate character object

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {

    //point buy
    private int attributePoints;

    //attributes
    private float
        strength,
        dexterity,
        constitution,
        intelligence,
        wisdom,
        charisma,
        
        armorClass,
        
        HP,
        maxHP;

    //attributes text
    private Text
        strText,
        dexText,
        conText,
        intText,
        wisText,
        chaText,

        ACText,

        HPText,
        maxHPText,
        
        APText;

    //flags

    // Use this for initialization
    void Start () {
        //initial point buy
        attributePoints = 15;

        //initial stat distribution
        strength = dexterity = constitution = intelligence = wisdom = charisma = armorClass = HP = 10f;


        //grab our texts
        strText = GameObject.Find("StrText").GetComponent<Text>();
        dexText = GameObject.Find("DexText").GetComponent<Text>();
        conText = GameObject.Find("ConText").GetComponent<Text>();
        intText = GameObject.Find("IntText").GetComponent<Text>();
        wisText = GameObject.Find("WisText").GetComponent<Text>();
        chaText = GameObject.Find("ChaText").GetComponent<Text>();

        ACText = GameObject.Find("ACText").GetComponent<Text>();

        HPText = GameObject.Find("HPText").GetComponent<Text>();
        maxHPText = GameObject.Find("MaxHPText").GetComponent<Text>();

        APText = GameObject.Find("APText").GetComponent<Text>();

        //update character sheet
        updateSheet();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void updateSheet()
    {
        //update numerical values
        armorClass = 10 + (int)((dexterity - 10) / 2);
        HP = maxHP = 10 + (int)((constitution - 10) / 2);

        //update texts last
        strText.text = "Str: " + strength;
        dexText.text = "Dex: " + dexterity;
        conText.text = "Con: " + constitution;
        intText.text = "Int: " + intelligence;
        wisText.text = "Wis: " + wisdom;
        chaText.text = "Cha: " + charisma;

        ACText.text = "AC: " + armorClass;

        HPText.text = "HP: " + HP;
        maxHPText.text = "/ " + maxHP;

        APText.text = "Points: " + attributePoints;
    }

    //increment stats
    public void incrementStrength()
    {
        if (attributePoints > 0 && strength < 18)
        {
            ++strength;
            --attributePoints;
            updateSheet();
        }
    }

    public void incrementDexterity()
    {
        if (attributePoints > 0 && dexterity < 18)
        {
            ++dexterity;
            --attributePoints;
            updateSheet();
        }
    }

    public void incrementConstitution()
    {
        if (attributePoints > 0 && constitution < 18)
        {
            ++constitution;
            --attributePoints;
            updateSheet();
        }
    }

    public void incrementIntelligence()
    {
        if (attributePoints > 0 && intelligence < 18)
        {
            ++intelligence;
            --attributePoints;
            updateSheet();
        }
    }

    public void incrementWisdom()
    {
        if (attributePoints > 0 && wisdom < 18)
        {
            ++wisdom;
            --attributePoints;
            updateSheet();
        }
    }

    public void incrementCharisma()
    {
        if (attributePoints > 0 && charisma < 18)
        {
            ++charisma;
            --attributePoints;
            updateSheet();
        }
    }

    //decrement stats
    public void decrementStrength()
    {
        if (strength > 3)
        {
            --strength;
            ++attributePoints;
            updateSheet();
        }
    }

    public void decrementDexterity()
    {
        if (dexterity > 3)
        {
            --dexterity;
            ++attributePoints;
            updateSheet();
        }
    }

    public void decrementConstitution()
    {
        if (constitution > 3)
        {
            --constitution;
            ++attributePoints;
            updateSheet();
        }
    }

    public void decrementIntelligence()
    {
        if (intelligence > 3)
        {
            --intelligence;
            ++attributePoints;
            updateSheet();
        }
    }

    public void decrementWisdom()
    {
        if (wisdom > 3)
        {
            --wisdom;
            ++attributePoints;
            updateSheet();
        }
    }

    public void decrementCharisma()
    {
        if (charisma > 3)
        {
            --charisma;
            ++attributePoints;
            updateSheet();
        }
    }
}
