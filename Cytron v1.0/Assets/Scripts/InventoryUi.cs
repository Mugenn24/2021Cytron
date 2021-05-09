using UnityEngine;



public class InventoryUi : MonoBehaviour
{

    public Transform itemsParent;

    InventorySlot[] slots;
    // Start is called before the first frame update
    Inventory inventory;
    void Start()
    {
        inventory = Inventory.instance;
        inventory.onItemChangedCallback += UpdateUI;

        slots = itemsParent.GetComponentsInChildren<InventorySlot>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void UpdateUI()
    {
        for (int i = 0; i < slots.Length; i++)
        {
            if(i < inventory.items.Count)
            {
                slots[i].AddItem(inventory.items[i]);
            } else
            {
                slots[i].ClearSlot();
            }
        }
        Debug.Log("Updating UI");

    }
}
