using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aimRotate : MonoBehaviour
{
    public GameObject target;
    public Rigidbody2D self;
    void FixedUpdate()
    {
        Vector3 lookDir = target.transform.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
        self.rotation = angle;        
    }
}
