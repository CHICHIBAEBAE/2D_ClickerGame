using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touch : MonoBehaviour
{
    public GameObject rangeOb;
    PolygonCollider2D rangeCol;

    private void Awake()
    {
        rangeCol = GetComponent<PolygonCollider2D>();
    }

    private void OnMouseDown()
    {
        Debug.Log("Touch");
        
    }
}

