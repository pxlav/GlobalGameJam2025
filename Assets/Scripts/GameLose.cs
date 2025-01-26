using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLose : MonoBehaviour
{
    public MainMenu menu;
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
    }
}
