using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody rigidbodyComponent;
    [SerializeField] private Transform transformComponent;
    [SerializeField] private PlayerInputScript PlayerInput;


    [SerializeField] float movementSpeed = 1f;
    [SerializeField] float jumpForce = 100f;

    bool isGrounded;

    private void Awake()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void FixedUpdate()
    {
        //rigidbodyComponent.velocity = new Vector3(PlayerInput.horizontalInput * movementSpeed, 0, PlayerInput.verticalInput * movementSpeed);

        if (PlayerInput.verticalInput != 0)
        {
            transformComponent.position += transform.forward * PlayerInput.verticalInput * movementSpeed;
        }

        if (PlayerInput.horizontalInput != 0)
        {
            transformComponent.position += transform.right * PlayerInput.horizontalInput * movementSpeed;
        }

        if (PlayerInput.jump==true)
        {
            rigidbodyComponent.AddForce(Vector3.up * jumpForce , ForceMode.VelocityChange);

            PlayerInput.jump = false;
            PlayerInput.isGrounded = false;
        }
        
    }
}
