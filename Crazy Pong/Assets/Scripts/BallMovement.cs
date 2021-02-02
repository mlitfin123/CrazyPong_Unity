using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    private Rigidbody2D rb2d;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        Invoke("GoBall", 1);
    }

    // Update is called once per frame
    void Update()
    {
        if (Lives.lives <= 0)
        {
            Invoke("TurnOffGameObject", 0f);
        }
    }
    void GoBall()
    {
        float rand = Random.Range(0, 2);
        if (rand < 1)
        {
            rb2d.AddForce(new Vector2(25, -25));
        }
        else
        {
            rb2d.AddForce(new Vector2(-25, -25));
        }
    }
    void TurnOffGameObject()
    {
        gameObject.SetActive(false);
    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.collider.CompareTag("Player"))
        {
            Vector2 vel;
            vel.x = rb2d.velocity.x / 2 + (coll.collider.attachedRigidbody.velocity.x / 2);
            vel.y = (rb2d.velocity.y);
            rb2d.velocity = vel;
        }
        if (coll.collider.CompareTag("Enemy"))
        {
            Vector2 vel;
            vel.x = rb2d.velocity.x + (coll.collider.attachedRigidbody.velocity.x / 2);
            vel.y = (rb2d.velocity.y);
            rb2d.velocity = vel;
        }
    }
}
