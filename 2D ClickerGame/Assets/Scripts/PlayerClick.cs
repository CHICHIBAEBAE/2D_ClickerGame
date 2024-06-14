using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerClick : MonoBehaviour
{
    

    public float damage;
    public Transform damageTxtPosition;

    private void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Attack();
        }
    }

    public void Attack()
    {
        Vector3 pos = Camera.main.ScreenToWorldPoint(damageTxtPosition.position);
        DamageTextController.Instance.CreateDamageText(pos, damage);
    }
}
