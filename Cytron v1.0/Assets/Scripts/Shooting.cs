using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform firepoint;
    public GameObject bulletobj;

    public float bulletforce = 20f;


    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1")){
            Shoot();
        }
    }

    void Shoot(){
        GameObject bullet = Instantiate(bulletobj, firepoint.position, firepoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firepoint.up*bulletforce, ForceMode2D.Impulse);
    }

}
