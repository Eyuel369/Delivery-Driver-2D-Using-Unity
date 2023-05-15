using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{

    [SerializeField]float Collide = 5f;
    [SerializeField] float steerSpeed = 300f;
   [SerializeField] float moveSpeed = 10f;
    void Start()
    {
        
    }

    void OnCollisionEnter2D(Collision2D other) 
    {
        if(moveSpeed > 5f){
         moveSpeed -= Collide;
        }
            
    }

    void OnTriggerEnter2D(Collider2D other) {

        if (other.tag == "Booster"){
            moveSpeed += Collide;
        }
    }
    // Update is called once per frame
    void Update()
    {

        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime ;

        transform.Rotate(0,0,-steerAmount);
        transform.Translate(0,moveAmount,0);
    }
}
