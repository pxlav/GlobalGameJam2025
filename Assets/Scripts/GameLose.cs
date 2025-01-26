using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameLose : MonoBehaviour
{
    public MainMenu menu;
    public Timer timer;
    public TextMeshProUGUI timerText;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Bubble1" || collision.tag == "Bubble2")
        {
            Losing();
        }
    }
    void Losing()
    {
        menu.menuStates = 4;
        timer.isLose = true;
        timerText.text = "Czas: " + timer.timer.ToString("0.0");
    }
}
