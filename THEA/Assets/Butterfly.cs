using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Butterfly : MonoBehaviour
{

    public float speed = 2.0f;
    public Vector3 newpos;

    public float timer;
    public float timerSpeed;
    public float timeToMove;
    void Start()
    {
        newpos = new Vector3(Random.Range(-8f, 8f), Random.Range(-4f, 4f), 0);
    }

    void Update()
    {
        timer += Time.deltaTime * timerSpeed;

        if (timer >= timeToMove)
        {
            transform.position = Vector3.Lerp(transform.position, newpos, Time.deltaTime * speed);

            if (Vector3.Distance(transform.position,newpos) <= 0.5f)
            {
                newpos = new Vector3(Random.Range(-8f, 8f), Random.Range(-4f, 4f), 0);

                timer = 0.0f;
            }
        }
    }
}
