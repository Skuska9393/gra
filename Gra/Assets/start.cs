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
        // Możesz wyświetlić okno "O nas" lub załadować scenę z informacjami
    }

    public void ExitGame()
    {
        Application.Quit(); // Tylko działa na urządzeniu
    }

   
}