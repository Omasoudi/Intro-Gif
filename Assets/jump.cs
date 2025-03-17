using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class jump : MonoBehaviour
{
    public float jumpForce = 7f; // Force du saut
    public float groundCheckDistance = 0.1f; // Distance pour vérifier si le joueur est au sol
    public LayerMask groundLayer; // Couche de terrain pour vérifier si le joueur est au sol

    private Rigidbody rb;
    private bool isGrounded;

    void Start()
    {
        // Récupère le composant Rigidbody attaché au joueur
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Vérifie si le joueur est au sol en utilisant un Raycast vers le bas
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
