using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl2 : MonoBehaviour
{
    [SerializeField]
    private Transform[] pictures;


    [SerializeField]
    private GameObject winText;
    public static bool youWin;
    [SerializeField]
    private GameObject nextlevel;
    // Start is called before the first frame update
    void Start()
    {
        winText.SetActive(false);
        youWin = false;
    }

    // Update is called once per frame
    void Update()
    {
     if (pictures[0].rotation.z == 0 &&
            pictures[1].rotation.z == 0 &&
            pictures[2].rotation.z == 0 &&
            pictures[3].rotation.z == 0 &&
            pictures[4].rotation.z == 0 &&
            pictures[5].rotation.z == 0 &&
            pictures[6].rotation.z == 0 &&
            pictures[7].rotation.z == 0 &&
            pictures[8].rotation.z == 0 &&
            pictures[9].rotation.z == 0 &&
            pictures[10].rotation.z == 0 &&
            pictures[11].rotation.z == 0 )
        {
            youWin = true;
            winText.SetActive(true);
            nextlevel.SetActive(true);
        }
    }
}
