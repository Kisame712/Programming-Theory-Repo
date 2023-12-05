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
    // Start is called before the first frame update

}
