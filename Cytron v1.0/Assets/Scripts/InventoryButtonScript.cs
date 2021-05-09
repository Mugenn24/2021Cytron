using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class InventoryButtonScript: MonoBehaviour
{

    public Button InventoryButton; 
    InventoryHideUnhide inventoryhideunhide;
    GameObject RequiredObject;
    GameObject RequiredObjectChild;

    void Start()
    {
        RequiredObject = GameObject.Find("Canvas"); 
        RequiredObjectChild = RequiredObject.transform.GetChild(0).gameObject;
        inventoryhideunhide = RequiredObjectChild.GetComponent<InventoryHideUnhide>();

        Button btn = gameObject.GetComponent<Button>();
        btn.onClick.AddListener(dothis);

    } 

    void dothis(){
        Debug.Log("You have clicked the button!"); 
        inventoryhideunhide.Switch();


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
