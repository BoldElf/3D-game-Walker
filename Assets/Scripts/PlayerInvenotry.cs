using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInvenotry : MonoBehaviour
{
    [SerializeField] private KeyPickup keyPickup;
    private int key;

    public int Key => key;

    private void Start()
    {
        if(keyPickup != null)
        {
            keyPickup.plusKey += keyPlus;
        }
        
    }

    private void keyPlus()
    {
        key++;
        Debug.Log(key);
    }
}
