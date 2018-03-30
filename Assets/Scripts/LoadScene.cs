using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour {
    
    public void LoadNewScene(string scene) {
        //Application.LoadLevel(scene);
        SceneManager.LoadScene("Scenes/" + scene, LoadSceneMode.Single);
    }

}
