using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivesScript : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Ball")
        {
            //add score when ball hits top
            Lives.lives -= 1;
        }
    }
}
