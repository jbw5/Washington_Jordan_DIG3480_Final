using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NinjaShooter : MonoBehaviour
{
    public GameObject FireSkill;
    Animator fireAnim;
    private Rigidbody2D frb;

    private void FixedUpdate()
    {
        if (Input.GetKey("escape"))
            Application.Quit();
    }

    void Awake()
    {
        frb = GetComponent<Rigidbody2D>();
        fireAnim = GetComponent<Animator>();
    }
    void Start ()
    {
        StartCoroutine(Fire());
    }

    IEnumerator Fire()
    {
        yield return new WaitForSeconds(Random.Range(1, 4));
        Instantiate(FireSkill, transform.position, Quaternion.identity);
        fireAnim.SetInteger("State", 3);
       
        StartCoroutine(Fire());
    }
}
