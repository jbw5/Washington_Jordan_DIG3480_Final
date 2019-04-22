using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall : MonoBehaviour
{
    float moveSpeed = 7f;
    Rigidbody2D fbrb;
    PlayerController target;
    Vector2 moveDirection;

    void Start ()
    {
        fbrb = GetComponent<Rigidbody2D>();
        target = GameObject.FindObjectOfType<PlayerController>();
        moveDirection = (target.transform.position - transform.position).normalized * moveSpeed;
        fbrb.velocity = new Vector2(moveDirection.x, moveDirection.y);
        Destroy(gameObject, 1f);

       
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Knight"))
        {
            Debug.Log("Hit");
            Destroy(gameObject);
        }


    }
    
}
