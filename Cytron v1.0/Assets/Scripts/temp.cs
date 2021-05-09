using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class temp : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform player;
    public Rigidbody2D rb;
    public Rigidbody2D rb2;
    public Camera cam;
    Vector2 mousePos;
    Vector2 movement;
    public float moveSpeed = 5f;

    //public Vector3 offset;
    
    // Update is called once per frame
    void Update()
    {
        transform.position = rb2.position;
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
    }

    void FixedUpdate(){

        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
        Vector2 lookDir = mousePos - rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = angle;
    }
}
