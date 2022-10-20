using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{

    [SerializeField] PlayerInputScript playerInput;
    [SerializeField] Transform playerTransform;
    

    private float xRotation = 0f;

    void Start()
    {
        
    }

    
    void Update()
    {

        xRotation += playerInput.mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerTransform.Rotate(Vector3.up * playerInput.mouseX);

    }
}
