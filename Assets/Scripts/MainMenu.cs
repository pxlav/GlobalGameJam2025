using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public int menuStates;// Screen press e to continue i muzyka glowny screen z menu potem start to slajdy z voice i potem gra juz ale ze skipem
    public GameObject[] menuObjs;
    public float voiceOverTimer;
    public float endTimer;
    public GameObject gameObj;
    private void Start()
    {
        menuStates = 0;
        gameObj.SetActive(false);
        endTimer = 3.0f;
    }
    private void Update()
    {
        if(menuStates == 0)
        {
            menuObjs[0].SetActive(true);
            menuObjs[1].SetActive(false);
            menuObjs[2].SetActive(false);
            menuObjs[3].SetActive(false);
            menuObjs[4].SetActive(false);
            if(Input.GetKeyDown(KeyCode.Space))
            {
                menuStates = 1;
            }
        }
        if (menuStates == 1)
        {
            menuObjs[0].SetActive(false);
            menuObjs[1].SetActive(true);
            menuObjs[2].SetActive(false);
            menuObjs[3].SetActive(false);
            menuObjs[4].SetActive(false);
        }
        if (menuStates == 2)
        {
            menuObjs[0].SetActive(false);
            menuObjs[1].SetActive(false);
            menuObjs[2].SetActive(true);
            menuObjs[3].SetActive(false);
            menuObjs[4].SetActive(false);
            voiceOverTimer -= Time.deltaTime;
            if(voiceOverTimer <= 0)
            {
                menuStates = 3;
            }
            if(Input.GetKeyDown(KeyCode.Space))
            {
                menuStates = 3;
            }
        }
        if (menuStates == 3)
        {
            menuObjs[0].SetActive(false);
            menuObjs[1].SetActive(false);
            menuObjs[2].SetActive(false);
            menuObjs[3].SetActive(true);
            menuObjs[4].SetActive(false);
            gameObj.SetActive(true);
        }
        if (menuStates == 4)
        {
            menuObjs[0].SetActive(false);
            menuObjs[1].SetActive(false);
            menuObjs[2].SetActive(false);
            menuObjs[3].SetActive(false);
            menuObjs[4].SetActive(true);
            endTimer -= Time.deltaTime;
            if(endTimer <= 0)
            {
                SceneManager.LoadScene(0);
            }
        }
    }
    public void PlayButton()
    {
        menuStates = 2;
    }
    public void ExitButton()
    {
        Application.Quit();
    }
}
