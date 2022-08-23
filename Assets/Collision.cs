using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    // utkozes
    void OnCollisionEnter2D(Collision2D other) 
    {
        Debug.Log("utkozoss van");
    }
    private void OnTriggerEnter2D(Collider2D other) {
        Debug.Log("trigger");
    }
}
