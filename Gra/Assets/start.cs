using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("wyboretapu"); // podaj nazwę sceny gry
    }

    public void ShowAbout()
    {
        SceneManager.LoadScene("Tworcy"); // podaj nazwę sceny gry
    }

    public void ExitGame()
    {
        Application.Quit(); // Wyłącza aplikację
        Debug.Log("Gra została zamknięta!"); // Wyświetli komunikat w edytorze Unity (działa tylko w edytorze).
    }
     public void Gra2()
    {
        SceneManager.LoadScene("segregowaniesmieci"); // podaj nazwę sceny gry
    }
      public void Gra1()
    {
        SceneManager.LoadScene("Obracanepuzzle"); // podaj nazwę sceny gry
    }
    public void Gra3()
    {
        SceneManager.LoadScene("Obracanepuzzle 2"); // podaj nazwę sceny gry
    }
}