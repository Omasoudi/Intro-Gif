using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggertrap : MonoBehaviour
{
    public GameObject objectWithPhysics; 
    private Rigidbody rb;

    void Start()
    {
        
        if (objectWithPhysics != null)
        {
            rb = objectWithPhysics.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.isKinematic = true; 
                rb.useGravity = false;
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
           
            if (rb != null)
            {
                rb.isKinematic = false; 
                rb.useGravity = true;
            }

            
            // ce script désactive isKenetic dans le rigid body de la boule pour lui donner de la physique et qu'elle tombe sur le joueur
        }
    }
}
