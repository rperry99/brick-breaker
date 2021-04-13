using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Need this for scene management

public class SceneLoader : MonoBehaviour {
    public void LoadNextScene() {
        // Find the active scene and get its index.
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        // Load next scene
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    public void LoadFistScene() {
        SceneManager.LoadScene(0);
    }
}
