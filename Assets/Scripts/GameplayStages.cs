using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayStages : MonoBehaviour
{
    public int whichState; // 0 - main 1 - medium 2 - hard
    public GameObject[] statesObj; // -||-

    private void Update()
    {
        if(whichState == 0)
        {
            statesObj[0].SetActive(true);
            statesObj[1].SetActive(false);
        }
        if(whichState == 1)
        {
            statesObj[0].SetActive(false);
            statesObj[1].SetActive(true);
        }
        if(whichState == 2)
        {
            statesObj[0].SetActive(false);
            statesObj[1].SetActive(false);
        }
    }
}
