using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scorer : MonoBehaviour
{
    int score = 0;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag != "Hit")
        {
            score++;
            Debug.Log("You've bumped the all this many times : " + score);
        }
    }
}
