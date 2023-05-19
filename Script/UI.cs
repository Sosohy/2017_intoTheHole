using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour {

    public GameObject HowTO;
    public GameObject play;
    public GameObject gameStart;
    public GameObject CanV;

    void Start()
    {
        //화면크기 고정
        Screen.SetResolution(Screen.width, Screen.width * 9 / 16, false);
    }


    public void startM()
    {
        HowTO.SetActive(false);
        CanV.SetActive(true);
    }

    public void How()
    {
        CanV.SetActive(false);
        HowTO.SetActive(true);
    }

    public void startGame()
    {
        gameObject.SetActive(false);
        play.SetActive(true);
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
