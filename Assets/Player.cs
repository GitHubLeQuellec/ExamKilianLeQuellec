using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // La vitesse de d�placement horizontale du joueur
    public float horizontalSpeed = 5.0f;
    public Transform groundCheck;
    public LayerMask groundLayer;

    // La force de saut du joueur
    public float jumpForce = 10.0f;

    // Le Rigidbody2D du joueur
    private Rigidbody2D rb;

    // Bool�en indiquant si le joueur peut sauter
    private bool canJump;
    bool isGrounded = false;
    void Start()
    {
        // R�cup�re le Rigidbody2D du joueur
        rb = GetComponent<Rigidbody2D>();

        // Initialise le bool�en canJump � true
        canJump = false;
    }

    void Update()
    {
        // D�place le joueur horizontalement avec les touches Q et D
        float horizontalInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(horizontalInput * horizontalSpeed, rb.velocity.y);
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);

        if (isGrounded)
        {
            canJump = true;
        }


        // Fait sauter le joueur avec la barre d'espace s'il peut sauter
        // saut
        if (Input.GetKeyDown(KeyCode.Space) && canJump)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            canJump = false;
        }
    }
    // test pour GH

}
