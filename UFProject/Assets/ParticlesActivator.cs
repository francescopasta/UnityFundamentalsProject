using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticlesActivator : MonoBehaviour
{
    public GameObject rabbitParticles;
    private GameObject childObject;

    private void Start()
    {
        childObject = transform.GetChild(0).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if(childObject) 
        {
            
        }

    }
}
