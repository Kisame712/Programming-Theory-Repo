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
    // Start is called before the first frame update

}
