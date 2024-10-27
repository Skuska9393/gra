using System.Collections;
using System.Collections.Generic;
using UnityEditor.EditorTools;
using UnityEngine;

public class Puzzle : MonoBehaviour
{

    private void OnMouseDown()
    {
        if (!GameObjectToolContext.youWin)
            transform.Rotate(0f, 0f, 90f);
    }
        
    }
}
