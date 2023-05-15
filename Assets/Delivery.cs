using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField]Color32 hasPackageColor = new Color32 (1,1,1,1);
    [SerializeField]Color32 deliveredColor = new Color32 (0,0,0,1);
    [SerializeField]float time = 0f;

    
    bool hasPackage;
    SpriteRenderer sprite;

    void Start(){
      sprite = GetComponent<SpriteRenderer>();
     
    }
    void OnCollisionEnter2D(Collision2D other) 
    {
        Debug.Log("Ouch");
       
    }
    void OnTriggerEnter2D(Collider2D other) {
       if (other.tag == "Package"){
        if(!hasPackage){
          Debug.Log("Package Picked.");
          hasPackage = true;
          Destroy(other.gameObject,time);
          sprite.color = hasPackageColor;
        }else{
          Debug.Log("Package already picked.");
        }
            
       }
       if (other.tag == "Customer" ){
        if(hasPackage){
        Debug.Log("Package delivered.");
        hasPackage = false;
        sprite.color = deliveredColor;
       }else{
         Debug.Log("Package not picked.");
       }
       }
       
    }
}
