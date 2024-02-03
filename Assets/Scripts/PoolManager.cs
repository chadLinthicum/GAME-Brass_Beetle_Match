using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolManager : MonoBehaviour
{
    public GameObject particlePrefab;
    public int poolSize = 10;

    private Queue<GameObject> particlePool;

    private void Start()
    {
        particlePool = new Queue<GameObject>();

        for (int i = 0; i < poolSize; i++)
        {
            GameObject particle = Instantiate(particlePrefab, transform);
            particle.SetActive(false);
            particlePool.Enqueue(particle);
        }
    }

    public void SpawnParticle(Vector3 position)
    {
        if (particlePool.Count == 0)
        {
            Debug.LogWarning("Particle pool is empty! Consider increasing the pool size.");
            return;
        }

        GameObject particle = particlePool.Dequeue();
        particle.transform.position = position;
        particle.SetActive(true);
        // Play any additional particle-specific effects or animations here
    }

    public void RecycleParticle(GameObject particle)
    {
        particle.SetActive(false);
        particlePool.Enqueue(particle);
    }
}
