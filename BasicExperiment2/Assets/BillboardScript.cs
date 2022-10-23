using UnityEngine;

public class BillboardScript : MonoBehaviour
{

    Transform mainCamera;

    private void Start()
    {
        GameObject temp = GameObject.Find("PlayerCam");
        mainCamera = temp.transform;
    }
     
    void Update()
    {
        transform.LookAt(transform.position + mainCamera.forward);
    }
}
