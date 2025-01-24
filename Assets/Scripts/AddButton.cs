using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddButton : MonoBehaviour
{
    public bool isMouseOn;
    public Tower currentTower;
    private void Update()
    {
        if(isMouseOn == true && Input.GetMouseButtonDown(0) && currentTower.whichState < 3)
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
        currentTower.whichState++;
        currentTower.isChanging = true;
    }
}
