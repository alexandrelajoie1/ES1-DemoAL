using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectionPlateforme : MonoBehaviour
{
    // Start is called before the first frame update
    void OnCollisionEnter(Collision collision) {
        if(collision.gameObject.CompareTag("Plateforme")){
            Destroy(collision.gameObject);
        }
    
   }
}
