using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class QuestOne : MonoBehaviour
{
    public TextMeshProUGUI quest;

    public void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("Player") && !other.isTrigger) {
            quest.color = new Color32(38, 215, 0, 255);
        }
    }
}
