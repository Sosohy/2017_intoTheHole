using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class itemCreate : MonoBehaviour
{
    //게임종료화면 , 플레이화면
    public GameObject gameOver;
    public GameObject play;
    public GameObject gameSuccess;

    //아이템
    public GameObject cake;
    public GameObject potion;
    public GameObject clear;
   
    //랜덤자리
    Transform[] points;


    public int itemN = 0;
    public int potionCreate = 0;
    float timer = 0; //누적시간 저장

    void Start()
    {
        points = GameObject.Find("spawnPoints").GetComponentsInChildren<Transform>();
    }


    public void Update()
    {
        //시간 누적
        timer += Time.deltaTime;

        //1초마다 생성
        if (timer > 0.4f)
        {
            StartCoroutine(Createitem());

            //초기화
            timer = 0;
        }

        // 게임 판단
        //if (potionCreate == 15)
        //{
        //    play.SetActive(false);
        //    gameOver.SetActive(true);
        //}

    }


    private IEnumerator Createitem()
    {
        //토끼가 사라진 후에 아이템 나오도록
      yield return new WaitForSeconds(4.5f);

        int i = UnityEngine.Random.Range(1, points.Length);

        if (itemN != 6) //6개에 한번 물약 나오게
        {
            int itemNum = Random.Range(1, 4);

            //랜덤값에 따라 다른 아이템 생성.
            switch (itemNum)
            {
                case 1:
                    Instantiate(cake, points[i].position, points[i].rotation);
                    break;
                case 2:
                    Instantiate(clear, points[i].position, points[i].rotation);
                    break;
                case 3:
                    Instantiate(cake, points[i].position, points[i].rotation);
                    break;
            }

            itemN++;
        }
        else
        {
            if (play.activeSelf == false)
            {
                potionCreate = 0;
            }

            Instantiate(potion, points[i].position, points[i].rotation);
            potionCreate++;

            if (potionCreate == 15)
            {
                play.SetActive(false);
                gameOver.SetActive(true);
            }
            itemN = 0;

        }
    }



}


