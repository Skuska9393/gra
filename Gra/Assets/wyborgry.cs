using UnityEngine;
using UnityEngine.SceneManagement;

public class wyborgry : MonoBehaviour
{
    // Funkcja ładowania sceny
    public void Gra2()
    {
        SceneManager.LoadScene("segregowaniesmieci");
    }
    public void Gra1()
    {
        SceneManager.LoadScene("Obracanepuzzle");
    }
}