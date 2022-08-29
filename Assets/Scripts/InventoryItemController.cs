using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryItemController : MonoBehaviour
{
    Item item;
    
    public Button RemoveButton;
    public Transform ItemContent;
    public GameObject InventoryItem;
    public void RemoveItem()
    {
        InventoryManager.Instance.Remove(item);
        Destroy(gameObject);
    }

  
    public void AddItem(Item newItem)
    {
        item = newItem;
    }

    public void UseItem()
    {

        switch (item.itemType) {

            case Item.ItemType.Potion:
                Player.Instance.IncreaseHealth(item.value);
                break;
            case Item.ItemType.Helm:
                Player.Instance.IncreaseArm(item.arm);
                break;
    }
            
            
        
        RemoveItem();
    }

    public void equipable()
    {
        //temp era el item temporal que iba a crear
        GameObject obj = Instantiate(InventoryItem, ItemContent);
        
        var itemName = obj.transform.Find("ItemName").GetComponent<Text>();
        var itemIcon = obj.transform.Find("ImageIcon").GetComponent<Image>();
        var removeButton = obj.transform.Find("RemoveButton").GetComponent<Button>();
        var eqButton = obj.transform.Find("Equipar").GetComponent<Button>();
        //Les pone el nombre y el ícono respectivos
        itemName.text = temp.itemName;
        itemIcon.sprite = temp.icon;
    }
}
