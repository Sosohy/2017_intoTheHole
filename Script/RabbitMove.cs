using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RabbitMove : MonoBehaviour {

    public GameObject rabbit;

    public const float rabbitmoveSpeed = 2.0f;
    void Update()
    {

        //토끼 움직임
        float r = rabbitmoveSpeed * Time.deltaTime;
        this.rabbit.transform.Translate(1 * r, 0, 0);
        Destroy(rabbit, 6);
    }

}
