using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour
{
    private void FixedUpdate()
    {
        if (Input.GetKey("escape"))
            Application.Quit();
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag=="Enemy")
        {
            Debug.Log("Hit");
            Destroy(col.gameObject);
          
        }
    }
 
}





