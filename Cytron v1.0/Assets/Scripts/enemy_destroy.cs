using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_destroy : MonoBehaviour
{

    public GameObject itemobj;
    // Start is called before the first frame update
    //public GameObject hiteffect;
    void OnCollisionEnter2D(Collision2D coll){

        //GameObject effect = Instantiate(hiteffect, transform.position, Quaternion.identity);
        //Destroy(effect, 5f);
        if(coll.collider.tag == "Player_Bullet"){
            GameObject item = Instantiate(itemobj, transform.position, transform.rotation);
            Destroy(gameObject);
            
        }

    }
}
