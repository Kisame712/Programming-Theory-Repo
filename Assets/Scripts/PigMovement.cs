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
}
