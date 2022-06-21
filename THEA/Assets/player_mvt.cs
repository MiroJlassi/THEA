using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_mvt : MonoBehaviour
{
    public player_controller controller;

    float horizmove = 0f;
    public float speed;


    bool jump = false;
    // Start is called before the first frame update
    void Update()
    {
        horizmove = Input.GetAxisRaw("Horizontal") * speed;

        if(Input.GetButtonDown("Jump"))
        {
            jump = true;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        controller.Move(horizmove * Time.fixedDeltaTime, false, jump);
        jump = false;
    }
}