using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemoryCard : MonoBehaviour
{
    [SerializeField] private GameObject cardBack;
    //[SerializeField] private Sprite image;
    [SerializeField] private SceneController controller;

    [SerializeField] private ParticleSystem match;
    
    private int _id;
    public int id { 
        get { return _id; }
    }

    public void SetCard(int id, Sprite image)
    {
        _id = id;
        GetComponent<SpriteRenderer>().sprite = image;
    }

    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseDown()
    {
        if (cardBack.activeSelf)
        {
            Instantiate(match);
            cardBack.SetActive(false);
            
        }
    }
}
