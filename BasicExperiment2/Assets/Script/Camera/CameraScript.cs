using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{

    [SerializeField] PlayerInputScript playerInput;
    [SerializeField] Transform cameraTransform;
    private float mouseSensivity;
    
    void Start()
    {
        
    }

    
    void FixedUpdate()
    {
        cameraTransform.localRotation = Quaternion.Euler(playerInput.mouseTurn.x * mouseSensivity, 0, 0);

    }
}
