using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followParent : MonoBehaviour
{
    public GameObject parent;

    void FixedUpdate()
    {
        this.transform.parent = parent.transform;
        this.transform.rotation = parent.transform.rotation;
    }
}
