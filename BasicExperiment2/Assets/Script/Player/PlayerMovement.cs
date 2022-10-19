using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody rigidbodyComponent;
    [SerializeField] private PlayerInputScript PlayerInput;

    [SerializeField] float movementSpeed = 10f;

    private void Awake()
    {

    }

    void FixedUpdate()
    {
        rigidbodyComponent.velocity = new Vector3(PlayerInput.horizontalInput * movementSpeed, 0, PlayerInput.verticalInput * movementSpeed);
    }
}
