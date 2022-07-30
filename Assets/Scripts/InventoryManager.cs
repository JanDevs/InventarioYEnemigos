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
        Console.WriteLine("Inicio");
        foreach ( var item in Items )
        {
            GameObject obj = Instantiate(InventoryItem, ItemContent);
            
            var itemName = obj.transform.Find("ItemName").GetComponent<Text>();
            Console.Write("Nombre");
            var itemIcon = obj.transform.Find("ImageIcon").GetComponent<Image>();
            Console.Write("Imagen");
            itemName.text = item.itemName;
            itemIcon.sprite = item.icon;
        }

    }
}
