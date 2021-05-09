using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercollision : MonoBehaviour
{
    public movement2d move;

    void OnCollisionEnter2D(Collision2D collisioninfo){
        // if (collisioninfo.collider.tag=="Obstacle"){
        //     //move.enabled = false;
        //     Debug.Log(collisioninfo.collider.name);
        // }
        Debug.Log(collisioninfo.collider.name);
    }


}
