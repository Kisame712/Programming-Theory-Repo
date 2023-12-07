using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PigMovement : AnimalMovement
{
    private void Awake()
    {
        movementSpeed = 8f;
        jumpForce = 4f;
    }
    private void Update()
    {
        //Movement
        if (Input.GetKey(KeyCode.Space))
        {
            Jump();
        }
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow))
        {
            MoveAnimal();
        }
    }
}
