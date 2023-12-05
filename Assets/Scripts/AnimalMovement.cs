using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalMovement : MonoBehaviour
{
    public Rigidbody animalRb;
    protected float jumpForce = 2f;
    protected float movementSpeed = 5f;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        //Movement
        if (Input.GetKey(KeyCode.Space))
        {
            Jump();
        }
        if(Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            MoveAnimal();
        }
    }
    public void Jump()
    {
        animalRb.AddForce(Vector3.up * Time.deltaTime * jumpForce);
    }
    public void MoveAnimal()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            animalRb.AddForce(Vector3.forward * Time.deltaTime * movementSpeed);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            animalRb.AddForce(Vector3.back * Time.deltaTime * movementSpeed);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            animalRb.AddForce(Vector3.left * Time.deltaTime * movementSpeed);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            animalRb.AddForce(Vector3.right * Time.deltaTime * movementSpeed);
        }
    }
}
