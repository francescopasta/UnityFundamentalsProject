using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetRabbit : MonoBehaviour
{
    public InventoryScript inventory;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && inventory.Rabbit == 1)
        {
            inventory.Rabbit = 0;
        }
    }
}
