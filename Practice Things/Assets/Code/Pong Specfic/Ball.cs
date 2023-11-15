using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float movementSpeed;
    public Vector3 direction;
    public float maxXPosition;


    // Update is called once per frame
    void Update()
    {
        Move();
        CheckBoundries();
    }

    void Move()
    {
        transform.position += direction * movementSpeed * Time.deltaTime;
    }

    public void Bounce(Vector3 newDirection)
    {
        direction = newDirection;
    }

    public void CheckBoundries()
    {
        if (transform.position.x > maxXPosition)
        {
            ScoreBoard.Instance.GivePointToP1();
            Destroy(gameObject);
        }
        else if (transform.position.x < -maxXPosition)
        {
            ScoreBoard.Instance.GivePointToP2();
            Destroy(gameObject);
        }
    }
}
