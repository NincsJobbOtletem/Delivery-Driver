using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]float steerSpeed = 1f;
    [SerializeField]float moveSpeed = 20f;
    [SerializeField]float slowedSpeed =  10f;
    [SerializeField]float boostSpeed=  30f;


    
    void Start()
    {
        Debug.Log("nincs bug amúgy csak start");
    }
    
    

    // Update is called once per frame
    void Update()
    {

        float steerAmout = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float speedAmout = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
       transform.Rotate(0,0,-steerAmout);
       transform.Translate(0, speedAmout, 0);

    }
    void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Booster"){
              moveSpeed = boostSpeed;
              Debug.Log(moveSpeed);
        }
        }
    void OnCollisionEnter2D(Collision2D other) 
    {
        moveSpeed = slowedSpeed;
        Debug.Log(moveSpeed);
    }
}
