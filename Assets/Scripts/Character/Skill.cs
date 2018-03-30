using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill {

    private string name;

	public Skill() {
        name = "Blankus";
    }

    public Skill(string name) {
        this.name = name;
    }

    void Cast()  {

    }

    public string Name() {
        return name;
    }
}
