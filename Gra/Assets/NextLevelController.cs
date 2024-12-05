using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelController : MonoBehaviour
{
    // Start is called before the first frame update
    void OnMouseDown()
    {
        LoadNextLevel();
    }

    // Funkcja ³adowania kolejnego poziomu
    void LoadNextLevel()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene("Obracanepuzzle 2");
        // SceneManager.LoadScene(currentSceneIndex + 1); 
    }
}
