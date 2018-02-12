using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour {

	// Use this for initialization
    public void LoadNewScene(string scene) {
        //Application.LoadLevel(scene);
        SceneManager.LoadScene(scene, LoadSceneMode.Single);
    }

}
