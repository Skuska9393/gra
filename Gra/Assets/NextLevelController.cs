using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelController : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("abcd");
        SceneManager.LoadScene("Obracanepuzzle 2"); // Wczytaj scenê Poziom2
    }
}
