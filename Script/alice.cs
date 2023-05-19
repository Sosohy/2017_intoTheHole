using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class alice : MonoBehaviour
{
    public AudioClip soundEffect;
    public Text ScoreText;

    public GameObject play, gameSuccess;

    int cake = 0;
    int potion = 0;


    void OnTriggerEnter2D(Collider2D coll)
    {
       

        if (coll.transform.tag == "cake")
        {
            AudioSource.PlayClipAtPoint(soundEffect, transform.position);
            cake += 10;
            //점수표시
            ScoreText.text = "S C O R E : " + cake.ToString();
       
        }

        //앨리스 작아지게
        if (coll.transform.tag == "potion")
        {
            AudioSource.PlayClipAtPoint(soundEffect, transform.position);
            Debug.Log("po");

            potion++;

            if (potion == 3)
            {
                transform.localScale = new Vector3(1.3f, 1.3f, 1.3f);
            }

            if (potion == 5)
            {
                transform.localScale = new Vector3(1.1f, 1.1f, 1.1f);
            }

            if (potion == 8)
            {
                transform.localScale = new Vector3(0.9f, 0.9f, 0.9f);
            }

            if (potion == 10)
            {
                transform.localScale = new Vector3(0.7f, 0.7f, 0.7f);
            }

            if (potion == 10)
            {
                play.SetActive(false);
                gameSuccess.SetActive(true);
            }
        }
    }
}


