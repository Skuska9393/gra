using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class SceneController : MonoBehaviour
{
    private static Stack<string> sceneStack = new Stack<string>();

    // Ładowanie nowej sceny i zapamiętanie poprzedniej
    public static void LoadScene(string sceneName)
    {
        // Dodaj obecną scenę do stosu
        sceneStack.Push(SceneManager.GetActiveScene().name);
        SceneManager.LoadScene(sceneName);
    }

    // Powrót do poprzedniej sceny
    public static void LoadPreviousScene()
    {
        if (sceneStack.Count > 0)
        {
            string previousScene = sceneStack.Pop();
            SceneManager.LoadScene(previousScene);
        }
        else
        {
            Debug.LogWarning("Brak poprzednich scen na stosie!");
        }
    }
}