using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveshootpoint : MonoBehaviour
{
    public float moveSpeed = 5f;

    public Rigidbody2D rb;

    public Camera cam;

    Vector2 movement;
    Vector2 mousePos;

    void Update()
    {
        //input
        movement.x = Input.GetAxisRaw("Horizontal"); //horizontal kb movement
        movement.y = Input.GetAxisRaw("Vertical"); //vertical kb movement

        mousePos = cam.ScreenToWorldPoint(Input.mousePosition); //mouse coordinates

    }

    void FixedUpdate(){
        //movement
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime); //body position

        Vector2 lookDir = mousePos - rb.position; //aim point
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = angle;

    }
}
