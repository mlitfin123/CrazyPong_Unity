using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public KeyCode moveLeft = KeyCode.LeftArrow;
    public KeyCode moveRight = KeyCode.RightArrow;
    public float speed; //indicates the speed of the player movement
    public float min_X, max_X; //indicates the min and max X value of the map
    public bool canControl = true;

    private Rigidbody2D rb2d;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }
    void Awake()
    {

    }

    void Update()
    {
        if (canControl) {
            MovePlayer();
        }
        if (Lives.lives <= 0)
        {
            Invoke("TurnOffGameObject", .7f);
            canControl = false;
        }
    }

    void MovePlayer() //allows the player to move up and down along the Y axis and not past the minimum or maximum Y values
    {
        var vel = rb2d.velocity;
        if (Input.GetKey(moveRight))
        {
            vel.x = speed;
        }
        else if (Input.GetKey(moveLeft))
        {
            vel.x = -speed;
        }
        else
        {
            vel.x = 0;
        }
        rb2d.velocity = vel;

        var pos = transform.position;
        if (pos.x > max_X)
        {
            pos.x = max_X;
        }
        else if (pos.x < min_X)
        {
            pos.x = min_X;
        }
        transform.position = pos;
    }

    void TurnOffGameObject()
    {
        gameObject.SetActive(false);
    }
    void OnTriggerEnter2D(Collider2D target)//destroys the player and turns off the bullet on collision
    {
        if (target.tag == "Enemy")
        {
            Lives.lives -= 1;
        }
        if (target.tag == "Bonus")
        {
        }
    }
}