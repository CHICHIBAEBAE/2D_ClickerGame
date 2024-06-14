using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoClicker : MonoBehaviour
{
    private bool isAutoClickerBuy = false;

    void Update()
    {
        if(isAutoClickerBuy)
        {
            StartCoroutine(AutoClick());
        }
    }

    IEnumerator AutoClick()
    {
        throw new NotImplementedException();
    }
}
