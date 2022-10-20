using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputScript : MonoBehaviour
{

    public float horizontalInput;
    public float verticalInput;

    public float mouseY;
    public float mouseX;


    [SerializeField] float mouseSensiviy = 100f;

    void Update()
    {

        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        mouseY = Input.GetAxis("Mouse Y") * mouseSensiviy * Time.deltaTime;
        mouseX = Input.GetAxis("Mouse X") * mouseSensiviy * Time.deltaTime;

    }
}
