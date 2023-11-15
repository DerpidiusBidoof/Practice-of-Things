using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision) //if anything collides with me, next step
    {
        if (collision.gameObject.GetComponent<Ball>()) //if what collides with me has the ball script
        {
            float ballHitXDirection = collision.gameObject.GetComponent<Ball>().direction.x; //getting ball component to get the direction and assign to ballHitXDirection
            float ballHitYDirection = -collision.gameObject.GetComponent<Ball>().direction.y; //getting ball component to get the direction and assign to ballHitYDirection

            Vector3 hitDirection = new Vector3(ballHitXDirection, ballHitYDirection, 0);
            collision.gameObject.GetComponent<Ball>().Bounce(hitDirection);
        }
    }
}
