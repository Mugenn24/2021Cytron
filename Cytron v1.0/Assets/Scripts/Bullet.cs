using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject hiteffect;
    void OnCollisionEnter2D(Collision2D coll){

        GameObject effect = Instantiate(hiteffect, transform.position, Quaternion.identity);
        Destroy(effect, 5f);
        Destroy(gameObject);
        Debug.Log(coll.collider.tag);
    }


}
