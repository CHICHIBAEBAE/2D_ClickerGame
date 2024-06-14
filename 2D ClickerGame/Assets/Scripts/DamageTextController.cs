using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DamageTextController : MonoBehaviour
{
    public Canvas canvas;
    public GameObject dmgTxt;

    private static DamageTextController instance = null;

    public static DamageTextController Instance
    {
        get
        {
            if (instance == null)
            {
                instance = GameObject.FindObjectOfType<DamageTextController>();
            }
            return instance;
        }
    }
        
    public void CreateDamageText(Vector3 position, float damage)
    {
        GameObject damageTxt = Instantiate(dmgTxt, position, Quaternion.identity, canvas.transform);
        damageTxt.GetComponent<Text>().text = damage.ToString();
    }

}
