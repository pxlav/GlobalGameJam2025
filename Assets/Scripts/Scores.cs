using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Scores : MonoBehaviour
{
    public TextMeshProUGUI scoresText;
    public int scoresCounter;

    private void Update()
    {
        scoresText.text = scoresCounter.ToString();
    }
}
