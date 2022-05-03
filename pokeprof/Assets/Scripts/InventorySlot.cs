using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InventorySlot : MonoBehaviour
{
    public Image icon;
    public TextMeshProUGUI stackSizeText;

    public void ClearSlot() {
        icon.enabled = false;
        stackSizeText.enabled = false;
    }

    public void DrawSlot(InventoryItem item) {
        if(item == null) {
             ClearSlot();
             return;
        } 

        icon.enabled = true;
        stackSizeText.enabled = true;

        icon.sprite = item.itemData.icon;
        stackSizeText.text = item.stackSize.ToString();
    }
}
