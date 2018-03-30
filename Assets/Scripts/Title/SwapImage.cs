using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwapImage : MonoBehaviour {
    public Sprite image;

   public void Swap(GameObject obj) {
        obj.GetComponent<Image>().sprite = image;
        obj.GetComponent<Image>().color = Color.white;
    }

}
