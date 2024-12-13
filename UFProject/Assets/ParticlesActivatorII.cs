using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticlesActivatorII : MonoBehaviour
{
    public GameObject particles;
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            particles.SetActive(true);
        }
    }
}
