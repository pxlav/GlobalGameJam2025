using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleManage : MonoBehaviour
{
    public GameObject bubbleObj;
    public Transform bubbleSpawnPoint;
    public float bubbleSpawnTimer;
    private void Start()
    {
        bubbleSpawnTimer = 0.3f;
    }

    private void Update()
    {
        bubbleSpawnTimer -= Time.deltaTime;
        if(bubbleSpawnTimer < 0)
        {
            SpawnBubble();
            bubbleSpawnTimer = 0.3f;
        }
    }

    void SpawnBubble()
    {
        Instantiate(bubbleObj, bubbleSpawnPoint);
    }
}
