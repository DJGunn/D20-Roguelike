using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadRaceDetails : MonoBehaviour {

    public void details(string race) {
        Race selected;
        switch (race) {
            case "Elf":
                    selected = new Elf();
                break;
            case "Human":
                selected = new Human();
                break;
            case "Orc":
                selected = new Orc();
                break;
            default:
                selected = new Race();
                break;
        }

        this.gameObject.transform.GetChild(0).GetComponent<Text>().text = selected.Name();
        this.gameObject.transform.GetChild(1).GetComponent<Text>().text = selected.Description();
        this.gameObject.transform.GetChild(2).GetComponent<Text>().text = selected.StatMods();
        this.gameObject.transform.GetChild(3).GetComponent<Text>().text = selected.Experience();
        this.gameObject.transform.GetChild(4).GetComponent<Text>().text = selected.RacialSkill();
    }
}
