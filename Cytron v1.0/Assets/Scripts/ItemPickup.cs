using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{

    public Item item; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void pickup()
    {
        if (Input.GetMouseButtonDown (0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                BoxCollider bc = hit.collider as BoxCollider;
                if(bc != null && hit.collider.gameObject == gameObject)
                {
                    bool WasPickedUp = Inventory.instance.Add(item);
                    if (WasPickedUp){
                        Debug.Log ("Picked up" + gameObject);
                        Debug.Log ("hitbox object: " + hit.collider.gameObject);
                        Destroy(hit.collider.gameObject);
                    }
                    
                    Debug.Log(item.name);
                }
            }
        }
        
    }
    // void pickup()
    // {
    //     if (Input.GetMouseButtonDown (0)) {
    //         bool WasPickedUp = Inventory.instance.Add(item);
    //         if (WasPickedUp){
    //             Debug.Log ("Picked up" + item.name);
    //             Destroy(gameObject);
    //         }
            
    //         Debug.Log(item.name);
    //     }
    // }

    // Update is called once per frame
    void Update()
    {
        pickup();   
    }
}

