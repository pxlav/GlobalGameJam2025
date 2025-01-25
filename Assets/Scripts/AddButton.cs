using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddButton : MonoBehaviour
{
    public bool isMouseOn;
    public Tower currentTower;
    public Scores scores;
    private void Update()
    {
        if (isMouseOn == true && Input.GetMouseButtonDown(0) && currentTower.whichState < 3)
        {
            ClickButton();
        }
    }

    private void OnMouseEnter()
    {
        isMouseOn = true;
    }
    private void OnMouseExit()
    {
        isMouseOn = false;
    }
    public void ClickButton()
    {
        if (currentTower.whichState == 1 && scores.scoresCounter >= 150)
        {
            scores.scoresCounter -= 150;
            currentTower.whichState++;
            currentTower.isChanging = true;
        }
        if (currentTower.whichState == 2 && scores.scoresCounter >= 300)
        {
            scores.scoresCounter -= 300;
            currentTower.whichState++;
            currentTower.isChanging = true;
        }
    }
}
