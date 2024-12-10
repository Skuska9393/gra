using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class backmenu : MonoBehaviour
{
    private void OnMouseDown()
    {
        // Za³aduj scenê "menuglowne" po klikniêciu na BoxCollider
        SceneManager.LoadScene("menuglowne");
    }
}

