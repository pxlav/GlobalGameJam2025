using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    public int whichClass;
    public int whichState;
    public GameObject[] classes;
    public GameObject[] states0;
    public GameObject[] states1;
    public GameObject[] states2;
    public GameObject[] states3;
    public GameObject[] skillsWindowsOff;
    public float changingTimer;
    public bool isChanging;
    public GameObject skillsObj;
    public Scores scores;
    public TouretteShooting touretteShooting;

    private void Start()
    {
        changingTimer = 0.5f;
        whichState = 1;
    }

    private void Update()
    {
        if(isChanging == true)
        {
            ChangingTower();
            changingTimer -= Time.deltaTime;
            if(changingTimer <= 0)
            {
                changingTimer = 0.5f;
                isChanging = false;
            }
        }
        if(whichClass == 0)
        {
            skillsObj.SetActive(false);
        }else
        {
            skillsObj.SetActive(true);
        }
    }
    public void ChangingTower()
    {
        for(int i = 0; i < 4; i++)
        {
            if(whichClass == i)
            {
                classes[i].SetActive(true);
            }else
            {
                classes[i].SetActive(false);
            }
        }
        for(int i = 0; i < 4; i++)
        {
            if(whichClass == 0)
            {
                if(i == whichState)
                {
                    states0[i].SetActive(true);
                }else
                {
                    states0[i].SetActive(false);
                }
            }
            if (whichClass == 1)
            {
                if (i == whichState)
                {
                    states1[i].SetActive(true);
                }
                else
                {
                    states1[i].SetActive(false);
                }
            }
            if (whichClass == 2)
            {
                if (i == whichState)
                {
                    states2[i].SetActive(true);
                }
                else
                {
                    states2[i].SetActive(false);
                }
            }
            if (whichClass == 3)
            {
                if (i == whichState)
                {
                    states3[i].SetActive(true);
                }
                else
                {
                    states3[i].SetActive(false);
                }
            }
        }
        if (whichState == 0)
        {
            skillsWindowsOff[0].SetActive(true);
            skillsWindowsOff[1].SetActive(true);
            skillsWindowsOff[2].SetActive(true);
        }
        if (whichState == 1)
        {
            skillsWindowsOff[0].SetActive(false);
            skillsWindowsOff[1].SetActive(true);
            skillsWindowsOff[2].SetActive(true);
        }
        if (whichState == 2)
        {
            skillsWindowsOff[0].SetActive(false);
            skillsWindowsOff[1].SetActive(false);
            skillsWindowsOff[2].SetActive(true);
        }
        if (whichState == 3)
        {
            skillsWindowsOff[0].SetActive(false);
            skillsWindowsOff[1].SetActive(false);
            skillsWindowsOff[2].SetActive(false);
        }
    }
}
