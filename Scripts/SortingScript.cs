using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SortingScript : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public SortingLayer sortingLayer; 
    // Start is called before the first frame update
    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y > -5 & transform.position.y < 1)
        {
            if(spriteRenderer.)
        }
        spriteRenderer.sortingLayerID = 1; 

    }
}
