using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalMovement : MonoBehaviour
{
    protected float jumpForce = 2f;
    protected float movementSpeed = 5f;
    // Start is called before the first frame update

    // Update is called once per frame
    public void Jump()
    {
        transform.Translate(jumpForce * Time.deltaTime * Vector3.up);
    }
    public void MoveAnimal()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(movementSpeed * Time.deltaTime * Vector3.forward);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(movementSpeed * Time.deltaTime * Vector3.back);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(movementSpeed * Time.deltaTime * Vector3.left);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(movementSpeed * Time.deltaTime * Vector3.right);
        }
    }
}
