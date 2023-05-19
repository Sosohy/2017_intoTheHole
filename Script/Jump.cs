using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{

    Rigidbody2D rigid;
    float JumpForce = 300.0f;

    void Start()
    {
        this.rigid = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            this.rigid.AddForce(transform.up * this.JumpForce);
        }
    } 
}

