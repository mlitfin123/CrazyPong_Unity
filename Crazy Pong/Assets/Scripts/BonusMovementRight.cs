using UnityEngine;

public class BonusMovementRight : MonoBehaviour
{
    //speed of forward movement
    public float speed = 5f;

    //indicates enemy can move
    public bool canMove = true;
    //indicates the boundary of the game map
    public float bound_x = 10f;

    public int bonusScore = 10;

    void Update()
    {
        Move();
        if (Lives.lives <= 0)
        {
            Invoke("TurnOffGameObject", 0f);
        }
    }

    void Move()
    {
        if (canMove)
        {
            //enemies move forward after spawning
            Vector3 temp = transform.position;
            temp.x += speed * Time.deltaTime;
            transform.position = temp;
            //remove game object after hitting the boundary
            if (temp.x > bound_x)
                gameObject.SetActive(false);
        }
    }
    void TurnOffGameObject()
    {
        gameObject.SetActive(false);
    }
    //determines the actions on collision
    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Ball")
        {
            //destroy enemy
            Invoke("TurnOffGameObject", 0f);
            ScoreScript.Score += bonusScore;
        }
    }
}