using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectItem : MonoBehaviour
{
    public InventoryScript inventory;
    public GameObject dialogueOne;
    public GameObject dialogueTwo;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            inventory.Rabbit = 1;
            inventory.Key = 1;
            dialogueOne.SetActive(false);
            dialogueTwo.SetActive(true);
            Destroy(gameObject);
        }
    }
}
