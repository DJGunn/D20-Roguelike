using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Open : MonoBehaviour {

    public void OpenObject(GameObject opened) {
        opened.SetActive(true);
    }
}
