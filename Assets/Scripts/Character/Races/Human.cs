using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human : Race {

    public Human() : base("Human",
                        "Humans are pretty basic, except they're pretty okay with technology I guess.",
                        new int[6] { 10, 10, 10, 10, 10, 10 },
                        1.0f,
                        new Skill("Spark of Genius")) {
        //Empty
    }
}
