using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody rigidbodyComponent;
    [SerializeField] private Transform transformComponent;
    [SerializeField] private PlayerInputScript PlayerInput;

    [SerializeField] float movementSpeed = 10f;
    [SerializeField] float mouseSensivity = 1f;

    private void Awake()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void FixedUpdate()
    {
        //rigidbodyComponent.velocity = new Vector3(PlayerInput.horizontalInput * movementSpeed, 0, PlayerInput.verticalInput * movementSpeed);

        if (PlayerInput.verticalInput != 0)
        {
            transformComponent.position += transform.forward * PlayerInput.verticalInput * movementSpeed * Time.deltaTime;
        }

        if (PlayerInput.horizontalInput != 0)
        {
            transformComponent.position += transform.right * PlayerInput.horizontalInput * movementSpeed * Time.deltaTime;
        }

        transform.localRotation = Quaternion.Euler(0, PlayerInput.mouseTurn.y * mouseSensivity, 0);
        
    }
}
