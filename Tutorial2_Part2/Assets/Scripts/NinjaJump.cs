using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NinjaJump : MonoBehaviour
{
    public float forceY = 300f;
    Animator ninjaAnim;
    private Rigidbody2D nrb;


    // Start is called before the first frame update
    void Awake()
    {
        nrb = GetComponent<Rigidbody2D>();
        ninjaAnim = GetComponent<Animator>();
    }
   

    // Update is called once per frame
    void Start()
    {
        StartCoroutine(Jump());
    }

    IEnumerator Jump()
    {
        yield return new WaitForSeconds(Random.Range(1, 2));
        forceY = Random.Range(250, 350);
        nrb.AddForce(new Vector2(0, forceY));
        ninjaAnim.SetInteger("State", 1);
        yield return new WaitForSeconds(1.5f);
        ninjaAnim.SetInteger("State", 0);
        StartCoroutine(Jump());
        
    }
}
