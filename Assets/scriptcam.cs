using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptcam : MonoBehaviour
{
    public float lookSpeedX = 2.0f;  // sensibilité horizontale
    public float lookSpeedY = 2.0f;  // sensibilité vertical
    public float moveSpeed = 5.0f;  // vitesse

    private float rotationX = 0;  //enregistre la rotation horizontal initiale
    private float rotationY = 0;  // enregistre la rotation vertivale initiale

    // Start is called before the first frame update
    public void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;  //bloque le curseur au millieu de l'écran
        Cursor.visible = false;  // cache le curseur
    }

    // Update is called once per frame
    public void Update()
    {
        rotationX -= Input.GetAxis("Mouse Y") * lookSpeedY;  // vu verticale
        rotationX = Mathf.Clamp(rotationX, -90f, 90f);  // bloque la vu vertical a 90 degrer

        rotationY += Input.GetAxis("Mouse X") * lookSpeedX;  // vu horizontale

        // Apply the rotation to the camera
        transform.localRotation = Quaternion.Euler(rotationX, rotationY, 0);

        
        
    }
}

