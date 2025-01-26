using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HowToPlayButton : MonoBehaviour
{
    public bool isMouseOn;
    public bool isOn;
    public GameObject htpObj;
    public AudioSource click;

    private void Update()
    {
        if (isMouseOn == true && Input.GetMouseButtonDown(0))
        {
            isOn = !isOn;
            click.Play();
        }
        if(isOn == true)
        {
            htpObj.SetActive(true);
            Time.timeScale = 0.0f;
            if(Input.GetKeyDown(KeyCode.Escape))
            {
                isOn = false;
            }
        }
        else
        {
            htpObj.SetActive(false);
            Time.timeScale = 1.0f;
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
}
