using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float movementSpeed;

    Rigidbody2D playerRigidbody;

    private void Start()
    {
        playerRigidbody = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        Movement();
    }
    
    void Movement()
    {
        bool upKeyPressed = false;
        bool downKeyPressed = false;
        bool leftKeyPressed = false;
        bool rightKeyPressed = false;

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.Space))
        {
            playerRigidbody.velocity = new Vector2(playerRigidbody.velocity.x, movementSpeed);
            upKeyPressed = true;
        }
        else { upKeyPressed = false; }

        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            playerRigidbody.velocity = new Vector2(playerRigidbody.velocity.x, -movementSpeed);
            downKeyPressed = true;
        }
        else { downKeyPressed = false; }

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            playerRigidbody.velocity = new Vector2(-movementSpeed, playerRigidbody.velocity.y);
            leftKeyPressed = true;
        }
        else { leftKeyPressed = false; }

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            playerRigidbody.velocity = new Vector2(movementSpeed, playerRigidbody.velocity.y);
            rightKeyPressed = true;
        }
        else { rightKeyPressed = false; }

        if (!upKeyPressed && !downKeyPressed && !leftKeyPressed && !rightKeyPressed)
        {
            playerRigidbody.velocity = new Vector2(0, 0);
        }
    }
}
