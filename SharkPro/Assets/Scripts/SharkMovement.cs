using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


/// <summary>
///  handles movement and all other shark input 
/// </summary>

public class SharkMovement : MonoBehaviour
{
    float turnInputX;
    float turnInputY;
    float forwardInput;

    public float swimSpeed;


    public float turnSpeed;
    public float turnRate;

    Rigidbody sharkRB;

    public Shark shark;



    // Start is called before the first frame update
    void Start()
    {
        sharkRB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Swim();
        SharkTurn();
    }

    //checks if the player is hitting one or more  of the direction keys
    public void SiwmDirection(InputAction.CallbackContext ctx)
    {
        turnInputX = ctx.ReadValue<Vector2>().x;
        turnInputY = ctx.ReadValue<Vector2>().y;
    }

    public void SiwmForward(InputAction.CallbackContext ctx)
    {
        forwardInput = ctx.ReadValue<Vector2>().y;
    }

    public void Bite(InputAction.CallbackContext ctx)
    {
        shark.isBiting = ctx.ReadValueAsButton();
    }

    void Swim()
    {
        sharkRB.velocity = new Vector3(sharkRB.velocity.x, sharkRB.velocity.y, forwardInput) * swimSpeed * Time.fixedDeltaTime;
    }

    void SharkTurn()
    {
       sharkRB.velocity = new Vector3(sharkRB.velocity.x, turnInputY,sharkRB.velocity.z) * turnSpeed * Time.fixedDeltaTime;
        //transform.Rotate(Vector3.right,turnInputX* turnRate * Time.deltaTime);
      
    }

  

}
