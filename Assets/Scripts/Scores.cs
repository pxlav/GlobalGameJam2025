using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Scores : MonoBehaviour
{
    public TextMeshPro scoresText;
    public int scoresCounter;

    private void Start()
    {
        scoresCounter = 100;
    }
    private void Update()
    {
        scoresText.text = scoresCounter.ToString();
    }
}
