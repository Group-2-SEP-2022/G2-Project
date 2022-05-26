using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InventorySlot : MonoBehaviour
{
    public Image icon;
    public TextMeshProUGUI stackSizeText;

    //remove the icon and the stack size text from the inventory slot
    public void ClearSlot()
    {
        icon.enabled = false;
        stackSizeText.enabled = false;
    }

    //display the icon and the stack size text from the inventory slot
    public void DrawSlot(InventoryItem item)
    {
        if (item == null)
        {
            ClearSlot();
            return;
        }

        icon.enabled = true;
        stackSizeText.enabled = true;

        icon.sprite = item.itemData.icon;
        stackSizeText.text = item.stackSize.ToString();
    }
}
