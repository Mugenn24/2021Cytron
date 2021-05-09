using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asdadaf : MonoBehaviour
{
    public float moveSpeed = 50f;
    private Vector3 location;
    private Vector3 mousePos;
    public Rigidbody2D rb;
    private bool canMove = true;


    void Update()
    {
        

        if(Input.GetMouseButtonDown(0)){
            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePos.z = transform.position.z;
            location = Vector3.MoveTowards(transform.position, mousePos, moveSpeed * Time.deltaTime);
            //rb.velocity = location;
            }
        rb.MovePosition(location);
        
        canMove = true;
        //Debug.Log(canMove);
        
    }
    void OnCollisionEnter2D(Collision2D collisioninfo){
        // if (collisioninfo.collider.tag=="Obstacle"){
        //     //move.enabled = false;
        //     Debug.Log(collisioninfo.collider.name);
        // }
        
        canMove = false;
        Debug.Log(collisioninfo.collider.name);
    }




}

