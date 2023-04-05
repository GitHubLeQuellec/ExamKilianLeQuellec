using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platV : MonoBehaviour
{
    // Start is called before the first frame update
    // La vitesse de d�placement de la plateforme
    public float speed = 2.0f;

    // La distance maximale que la plateforme peut se d�placer
    public float distance = 5.0f;

    // La position de d�part de la plateforme
    private Vector3 startPosition;

    // La direction actuelle de la plateforme, soit 1 ou -1
    private float direction = 1.0f;

    void Start()
    {
        // Enregistre la position de d�part de la plateforme
        startPosition = transform.position;
    }

    void Update()
    {
        // D�place la plateforme dans la direction de l'axe X en utilisant la vitesse et la direction actuelle
        transform.Translate(Vector3.right * speed * direction * Time.deltaTime);

        // Si la plateforme a atteint sa distance maximale de d�placement � droite, inverse la direction pour la faire revenir � gauche
        if (transform.position.x > startPosition.x + distance)
        {
            direction = -1.0f;
        }
        // Si la plateforme a atteint sa distance maximale de d�placement � gauche, inverse la direction pour la faire revenir � droite
        else if (transform.position.x < startPosition.x)
        {
            direction = 1.0f;
        }
    }
}
