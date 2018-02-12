using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Close : MonoBehaviour {

    public void CloseObject (GameObject closed) {
        closed.SetActive(false);
    }

}
