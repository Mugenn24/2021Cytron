using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryHideUnhide : MonoBehaviour
{
    // Start is called before the first frame update
    public bool Visibility = false;
    void Start()
    {
        ShowOrNot();
    }

    void ShowOrNot(){
        gameObject.SetActive(Visibility);
    }

    public void Switch(){
        if(Visibility == false){
            Visibility = true;
        } else{
            Visibility = false;
        }

        ShowOrNot();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
