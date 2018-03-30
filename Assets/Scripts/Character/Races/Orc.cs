using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orc : Race {

    public Orc() : base("Orc",
                        "Orcs are the manliest race, even their women. Don't get in their way, or do, I don't care.",
                        new int[6] { 12, 8, 12, 8, 12, 8 },
                        1.3f,
                        new Skill("Tenacity")) {
        //Empty
    }

}