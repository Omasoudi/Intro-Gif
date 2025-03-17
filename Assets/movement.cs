using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float moveSpeed = 5.0f;  // Movement speed
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Initialize movement direction
        Vector3 moveDirection = Vector3.zero;

        // Use GetKey for WASD input
        if (Input.GetKey(KeyCode.W))  // avance devant
        {
            moveDirection += transform.forward;
        }
        if (Input.GetKey(KeyCode.S))  // avance dérrière
        {
            moveDirection -= transform.forward;
        }
        if (Input.GetKey(KeyCode.A))  // avance a gaucche
        {
            moveDirection -= transform.right;
        }
        if (Input.GetKey(KeyCode.D))  // avance a droite
        {
            moveDirection += transform.right;
        }

        //stabilise la vitesse peu importe la direction
        moveDirection.Normalize();

        // bouge le joueur
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime, Space.World);
    }
}
