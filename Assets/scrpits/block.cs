using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class block : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            GetComponent<MeshRenderer>().material.color = Color.red;
            gameObject.tag = "Hit";
        }
    }
}
