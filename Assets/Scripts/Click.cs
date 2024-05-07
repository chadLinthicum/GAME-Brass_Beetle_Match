using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour
{

    [SerializeField] private GameObject pfx_click;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void OnMouseDown()
    {
        StartCoroutine(ParticleSpawner());
    }

    private IEnumerator ParticleSpawner()
    {
        Vector3 mousePos = Input.mousePosition;
        Vector3 clickPos = Camera.main.ScreenToWorldPoint(mousePos);
        
        GameObject effect = ObjectPool.SharedInstance.GetPooledObject();
        if(effect != null)
        {
            Vector3 newPos = new Vector3(clickPos.x, clickPos.y, 0);
            effect.transform.position = newPos;
            effect.SetActive(true);
        }

        yield return new WaitForSeconds(1.5f);
        effect.SetActive(false);
    }
}
