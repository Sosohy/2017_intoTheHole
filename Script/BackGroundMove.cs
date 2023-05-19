using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundMove : MonoBehaviour {

    public float speed; //이동 속도
    

    void Update()
    {
        //왼쪽방향으로 speed만큼 이동.
        transform.Translate(Vector2.left * speed * Time.deltaTime);

        //x좌표가 -20보다 작아지게 되면...
        if (transform.position.x < -20.0f)
        {
            //위치를 0, 0 으로 옮겨줌.
            transform.position = new Vector2(0, 0);
        }

       

    }
}

