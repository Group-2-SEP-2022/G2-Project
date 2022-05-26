using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class Inventory : MonoBehaviour
{
    public static event Action<List<InventoryItem>> OnInventoryChange;

    public List<InventoryItem> inventory = new List<InventoryItem>();
    public Dictionary<ItemData, InventoryItem> itemDictionary =
        new Dictionary<ItemData, InventoryItem>();

    public TextMeshProUGUI quest;

    private void OnEnable()
    {
        Pokeball.OnPokeballCollected += Add;
    }

    private void OnDisable()
    {
        Pokeball.OnPokeballCollected -= Add;
    }
    
    //add item to the list of item
    public void Add(ItemData itemData)
    {
        if (itemDictionary.TryGetValue(itemData, out InventoryItem item))
        {
            item.AddToStack();
            OnInventoryChange?.Invoke(inventory);
        }
        else
        {
            InventoryItem newItem = new InventoryItem(itemData);
            inventory.Add(newItem);
            itemDictionary.Add(itemData, newItem);
            OnInventoryChange?.Invoke(inventory);
        }
    }

    //remove item to the list of item
    public void Remove(ItemData itemData)
    {
        if (itemDictionary.TryGetValue(itemData, out InventoryItem item))
        {
            item.RemoveFromStack();
            if (item.stackSize == 0)
            {
                inventory.Remove(item);
                itemDictionary.Remove(itemData);
            }
            OnInventoryChange?.Invoke(inventory);
        }
    }

    //check every frame if there is one item in the inventory
    void Update()
    {
        if (inventory.Count >= 1)
        {
            QuestTwo();
        }
    }

    //set the quest to completed
    public void QuestTwo()
    {
        quest.color = new Color32(38, 215, 0, 255);
    }
}
