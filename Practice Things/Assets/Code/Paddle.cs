using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Paddle : MonoBehaviour
{
    public float verticalMovementSpeed;
    public float maxYPosition;
    public KeyCode upKey;
    public KeyCode downKey;
    public int ballHitXDirection;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(upKey) && transform.position.y < maxYPosition) //if up key is pressed and we do not exceed the max Y position we can move up
        {
            MoveUp();
        }
        else if (Input.GetKey(downKey) && transform.position.y > -maxYPosition) //if down key is pressed and we do not exceed the negative max Y position we can move down
        {
            MoveDown();
        }
    }

    public void MoveUp()
    {
        transform.position += Vector3.up * verticalMovementSpeed * Time.deltaTime;  //time.delta time makes things run at the same speed regardless of processing power
    }

    public void MoveDown()
    {
        transform.position += Vector3.down * verticalMovementSpeed * Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D collision) //if anything collides with me, next step
    {
        if (collision.gameObject.GetComponent<Ball>()) //if what collides with me has the ball script
        {
            float yHitDirection = (collision.transform.position.y - transform.position.y);
            Vector3 hitDirection = new Vector3(ballHitXDirection, yHitDirection, 0); //hit direction changes ball x,y direction
            collision.gameObject.GetComponent<Ball>().Bounce(hitDirection); //puts hit direction into bounce from ball script
        }
    }
}
