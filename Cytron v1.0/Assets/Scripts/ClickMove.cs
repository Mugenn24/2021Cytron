using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickMove : MonoBehaviour
{
    public float moveSpeed = 4;
    private Vector2 location;
    private bool canMove = false;
    private bool isMoving = false;
    public static float healthbar;
     

    void Start(){
         healthbar = 0.03f;

    }

    void FixedUpdate()
    {      
        if(Input.GetMouseButton(1))
        {          
            setLocation();
        } 

        if(canMove)
        { 
            Move();
        }      
    }

    void setLocation()
    {
        location = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        isMoving = true;
        canMove = true;
    
    }

    void Move()
    {
        //transform.rotation = Quaternion.LookRotation(Vector2.forward, location);
        transform.position = Vector2.MoveTowards(transform.position, location, moveSpeed * Time.deltaTime);

    }

    void OnCollisionEnter2D(Collision2D collisioninfo)
    {
        canMove = false;
        healthbar -= 0.01f;
        if (healthbar <=0)
            Destroy (gameObject);

        Debug.Log("hit");
    }

}

