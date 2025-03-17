using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class jump : MonoBehaviour
{
    public float jumpForce = 7f; // Force du saut
    public float groundCheckDistance = 0.1f; // Distance pour v�rifier si le joueur est au sol
    public LayerMask groundLayer; // Couche de terrain pour v�rifier si le joueur est au sol

    private Rigidbody rb;
    private bool isGrounded;

    void Start()
    {
        // R�cup�re le composant Rigidbody attach� au joueur
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // V�rifie si le joueur est au sol en utilisant un Raycast vers le bas
        isGrounded = Physics.Raycast(transform.position, Vector3.down, groundCheckDistance, groundLayer);

        // Si le joueur appuie sur la touche "Jump" et est au sol, alors il saute
        if (isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }

    void Jump()
    {
        // Applique une force vers le haut sur le Rigidbody pour faire sauter le joueur
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }
}
