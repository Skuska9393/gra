using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class backmenu : MonoBehaviour
{
    private void OnMouseDown()
    {
        // Za�aduj scen� "menuglowne" po klikni�ciu na BoxCollider
        SceneManager.LoadScene("menuglowne");
    }
}

