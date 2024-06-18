using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Touch : MonoBehaviour
{
    public GameObject rangeOb;
    PolygonCollider2D rangeCol;

    
    public Animator animator;

    public float damage;
    public Transform damageTxtPosition;
    public TextMeshPro dmgTxt;


    private void Awake()
    {
        rangeCol = GetComponent<PolygonCollider2D>();
        animator = GetComponent<Animator>();
        dmgTxt = GetComponent<TextMeshPro>();
    }

    private void OnMouseDown()
    {
        Debug.Log("Touch");
        Attack();
    }

    public void Attack()
    {
        Vector3 position = damageTxtPosition.position;
        CreateDamageText(position, damage);
    }

    public void CreateDamageText(Vector3 position, float damage)
    {
        Instantiate(dmgTxt, position, Quaternion.identity);
        dmgTxt.text = damage.ToString();
    }

    
}

