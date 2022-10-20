using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputScript : MonoBehaviour
{

    public float horizontalInput;
    public float verticalInput;

    public Vector2 mouseTurn;

    void Update()
    {

        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        mouseTurn.x += Input.GetAxis("Mouse Y");
        mouseTurn.y += Input.GetAxis("Mouse X");

    }
}
