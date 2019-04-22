using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NinjaMover5 : MonoBehaviour
{
    public LayerMask enemyMask;
    public float speed = 1;

    float ninjaWidth;


    Rigidbody2D ninjaBody;
    Transform ninjaTrans;


    Vector2 pointA = new Vector2(58, -.5f);
    Vector2 pointB = new Vector2(59, -.5f);



    void Start()
    {
        ninjaTrans = this.transform;
        ninjaBody = this.GetComponent<Rigidbody2D>();
        ninjaWidth = this.GetComponent<SpriteRenderer>().bounds.extents.x;
    }



    void FixedUpdate()
    {
        Vector2 lineCast = ninjaTrans.position - ninjaTrans.right * ninjaWidth;
        Debug.DrawLine(lineCast, lineCast + Vector2.down);
        bool isGrounded = Physics2D.Linecast(lineCast, lineCast + Vector2.down, enemyMask);
        transform.position = Vector2.Lerp(pointA, pointB, Mathf.PingPong(Time.time, 1));

        if (!isGrounded)
        {
            Vector2 currRot = ninjaTrans.eulerAngles;
            currRot.y += 180;
            ninjaTrans.eulerAngles = currRot;

        }


        Vector2 ninjaVel = ninjaBody.velocity;
        ninjaVel.x = ninjaTrans.right.x * speed;
        ninjaBody.velocity = ninjaVel;
    }
}
