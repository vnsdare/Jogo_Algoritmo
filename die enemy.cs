using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nfhwhrhoerhewhou : MonoBehaviour
{
    //Code to Kill Enemy
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        GetComponentInParent<enemy1>().Die();
    }
}
