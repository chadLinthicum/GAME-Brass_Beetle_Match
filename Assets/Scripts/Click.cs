using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour
{
    [SerializeField] private ParticleSystem pfx_click;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseDown()
    {
        Vector3 mousePos = Input.mousePosition;
        Vector3 clickPos = Camera.main.ScreenToWorldPoint(mousePos);
        ParticleSystem effect = Instantiate(pfx_click);
        Vector3 newPos = new Vector3(clickPos.x, clickPos.y, 0);
        effect.transform.position = newPos;
    }
}
