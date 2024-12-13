using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateOpener : MonoBehaviour
{
    public Animator leftCage;
    public Animator rightCage;
    public InventoryScript inventory;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            leftCage.SetInteger("Key", inventory.Key);
            rightCage.SetInteger("Key", inventory.Key);
            leftCage.SetBool("PlayerClose", true);
            rightCage.SetBool("PlayerClose", true);

            inventory.Key = 0;
        }
    }
}
