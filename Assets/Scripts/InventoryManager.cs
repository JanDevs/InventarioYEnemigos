using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager Instance;
    public List<Item> Items = new List<Item>();

    public Transform ItemContent;
    public GameObject InventoryItem;

    private void Awake()
    {
        Instance = this;
    }

    public void Add(Item item)
    {
        Items.Add(item);
    }

    public void Remove(Item item)
    {
        Items.Remove(item);
    }

    public void ListItems()
    {
        //Limpieza del inventario
        foreach(Transform item in ItemContent)
        {
            Destroy(item.gameObject);
        }
        //Agregar items
        foreach ( var item in Items  )
        {
            //Instanciar un espacio y agregar las cosas
            GameObject obj = Instantiate(InventoryItem, ItemContent);
            var itemName = obj.transform.Find("ItemName").GetComponent<Text>();
            var itemIcon = obj.transform.Find("ImageIcon").GetComponent<Image>();
            //Les pone el nombre y el ícono respectivos
            itemName.text = item.itemName;
            itemIcon.sprite = item.icon;
        }

    }
}
