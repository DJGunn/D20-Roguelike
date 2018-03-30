using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elf : Race {

	public Elf() : base("Elf",
                        "Elves are super gay and stuff and all they can change genders at will.",
                        new int[6] { 8, 12, 8, 12, 8, 12 },
                        1.3f,
                        new Skill("Soul of the Forest")) {
        //Empty
    }
}
