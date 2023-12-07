using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SheepMovement : AnimalMovement
{
    private void Awake()
    {
        movementSpeed = 6f;
        jumpForce = 6f;
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
    // Start is called before the first frame update

}
