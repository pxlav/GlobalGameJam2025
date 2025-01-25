using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleManage : MonoBehaviour
{
    public GameObject[] bubbleObj;
    public Transform bubbleSpawnPoint;
    public float bubbleSpawnTimer;
    public int whichBubble;
    public float baseBubbleSpawnTimer;
    public float bubbleTimerMinus;
    public float bubbleMinusMultiplier;
    private void Start()
    {
        baseBubbleSpawnTimer = 5.0f;
        bubbleSpawnTimer = baseBubbleSpawnTimer;
    }

    private void Update()
    {
        bubbleTimerMinus += Time.deltaTime / bubbleMinusMultiplier;
        bubbleSpawnTimer -= Time.deltaTime;
        if(bubbleSpawnTimer < 0)
        {
            whichBubble = Random.Range(0, 2);
            SpawnBubble();
            bubbleSpawnTimer = baseBubbleSpawnTimer - bubbleTimerMinus;
        }
    }

    void SpawnBubble()
    {
        Instantiate(bubbleObj[whichBubble], bubbleSpawnPoint);
    }
}
