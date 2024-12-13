using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleWave : MonoBehaviour
{
    public GameObject[] particleSystems; // Assign your particle systems in the inspector
    public float delayBetweenParticles = 0.2f; // Time between activations
    public float particleLifetime = 2.0f; // Time before deactivation
    private bool isOver = false; 

    private void Start()
    {
        foreach (GameObject particle in particleSystems)
        {
            particle.SetActive(false);
        }
        StartCoroutine(ActivateParticlesLoop());
    }

    private void Update()
    {
        if (isOver)
        {
            StartCoroutine(ActivateParticlesLoop());
        }
    }

    private IEnumerator ActivateParticlesLoop()
    {
        foreach (GameObject particle in particleSystems)
        {
            isOver = false;
            particle.SetActive(true);
            yield return new WaitForSeconds(delayBetweenParticles);
            StartCoroutine(DeactivateParticle(particle));
        }
            // Optional: Add a delay between waves
           // yield return new WaitForSeconds(delayBetweenParticles * particleSystems.Length);
    }

    private IEnumerator DeactivateParticle(GameObject particle)
    {
        yield return new WaitForSeconds(particleLifetime);
        if(particle == particleSystems[particleSystems.Length - 1])
        {
            isOver = true;
        }
        particle.SetActive(false);
    }
}
