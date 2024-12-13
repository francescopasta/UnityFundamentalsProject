using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lighter : MonoBehaviour
{
    public GameObject particales;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            particales.SetActive(true);
        }
    }
}
