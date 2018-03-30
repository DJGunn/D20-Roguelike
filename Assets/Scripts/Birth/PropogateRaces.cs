using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropogateRaces : MonoBehaviour {
    public string path;
    [SerializeField] GameObject panelPrefab;
	// Use this for initialization
	void Start () {
        string[] files = new string[3] { "human", "elf", "orc" };

        for (int i = 0; i < 3; i++) {
            
            //Debug.Log(i);
            GameObject panel = (GameObject)Instantiate(panelPrefab, this.transform);
            panel.GetComponentInChildren<UnityEngine.UI.Text>().text = files[i];
        }
	
	}
	
}
