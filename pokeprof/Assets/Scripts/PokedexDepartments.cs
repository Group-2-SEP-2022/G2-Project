using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PokedexDepartments : MonoBehaviour
{
    public GameObject departmentEmpty;
    public GameObject departmentColor;
    public GameObject borderEmpty;
    public GameObject borderColor;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !other.isTrigger)
        {
            departmentEmpty.gameObject.SetActive(false);
            departmentColor.gameObject.SetActive(true);
            borderEmpty.gameObject.SetActive(false);
            borderColor.gameObject.SetActive(true);
        }
    }
}
