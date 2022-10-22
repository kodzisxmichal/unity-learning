using UnityEngine;

public class CameraPosition : MonoBehaviour
{
    [SerializeField] private Transform cameraPos;
   
    void Update()
    {
        transform.position = cameraPos.position;
    }
}
