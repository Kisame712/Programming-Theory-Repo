using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CowMovement : AnimalMovement
{
    //Inheritence
    private void Awake()
    {
        movementSpeed = 3f;
        jumpForce = 2f;
    }
    private void Update()
    {
        //Movement
        if (Input.GetKey(KeyCode.Space))
        {
            Jump();
        }
        else if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow))
        {
            MoveAnimal();
        }
    }
    
    // Start is called before the first frame update

}
