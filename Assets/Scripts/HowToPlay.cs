using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HowToPlay : MonoBehaviour
{
    public GameObject howToPlayObj;
    public bool isOn;
    public AudioSource click;

    private void Update()
    {
        if(isOn == true)
        {
            howToPlayObj.SetActive(true);
        }else
        {
            howToPlayObj.SetActive(false);
        }
    }
    public void howToPlayButton()
    {
        isOn = !isOn;
        click.Play();
    }
}
