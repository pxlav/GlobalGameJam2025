using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayStages : MonoBehaviour
{
    public int whichState; // 0 - main 1 - medium 2 - hard
    public GameObject[] statesObj; // -||-
    public BubbleManage bubbleManage;
    private void Start()
    {
        whichState = 0;
    }

    private void Update()
    {
        if(bubbleManage.bubbleTimerMinus < 1f && bubbleManage.bubbleTimerMinus > 0.1)
        {
            whichState = 0;
        }
        if (bubbleManage.bubbleTimerMinus < 2 && bubbleManage.bubbleTimerMinus > 1.5f)
        {
            whichState = 1;
        }
        if (bubbleManage.bubbleTimerMinus > 3f)
        {
            whichState = 2;
        }
        if (whichState == 0)
        {
            statesObj[0].SetActive(true);
            statesObj[1].SetActive(false);
            statesObj[2].SetActive(false);
        }
        if(whichState == 1)
        {
            statesObj[0].SetActive(false);
            statesObj[1].SetActive(true);
            statesObj[2].SetActive(false);
        }
        if(whichState == 2)
        {
            statesObj[0].SetActive(false);
            statesObj[1].SetActive(false);
            statesObj[2].SetActive(true);
        }
    }
}
