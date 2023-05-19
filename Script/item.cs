using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item : MonoBehaviour {

    public float speed; //이동 속도

    void Update()
    {
        //왼쪽 방향으로 speed만큼 움직임.
        transform.Translate(Vector2.left * speed * Time.deltaTime);

        // x 좌표가 -8 보다 작으면 해당 오브젝트를 삭제.
        if (transform.position.x < -8)
        {
            //오브젝트를 지워줌.
            Destroy(gameObject);
        }
    }

    //플레이어에게 부딪히면 사라짐
    void OnTriggerEnter2D(Collider2D coll)
    {

        if (coll.transform.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
