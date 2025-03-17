using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sens : MonoBehaviour
{
    public float mouseSensitivity = 100f;

    private Transform playerBody;

    private float xRotation = 0f;

    void Start()
    {
        // Assuming the camera is a child of the player body (e.g., in first-person view)
        playerBody = transform.parent;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        // Get mouse input
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        // Rotate the camera around X-axis (vertical looking)
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f); // Prevent flipping the camera

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        // Rotate the player body around Y-axis (horizontal looking)
        playerBody.Rotate(Vector3.up * mouseX);
    }

}
