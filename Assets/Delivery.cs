using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    // utkozes
    bool hasPackage;
    [SerializeField]float timeDisaper = 0.5f;

    [SerializeField] Color32 hasPackageColor = new Color32(255,0,0,255);
    [SerializeField] Color32 donthavePackageColor = new Color32(255,255,0,255);

    SpriteRenderer spriteRenderer;

    private void Start() {
        Debug.Log(hasPackage);
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.color = donthavePackageColor;

    }

    

    void OnCollisionEnter2D(Collision2D other) 
    {
        Debug.Log("utkozoss van");
    }
    void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Package" && !hasPackage){
              hasPackage = true;
              Debug.Log(hasPackage);
              spriteRenderer.color = hasPackageColor;

              Destroy(other.gameObject,timeDisaper);
        }
        if(other.tag == "customer" && hasPackage == true ){
              Debug.Log("Delivered to customer <3");
              hasPackage = false;
              spriteRenderer.color = donthavePackageColor;

              Debug.Log(hasPackage);
        }
        else{
            Debug.Log("Vegyél fel package");
        }


    }
}
