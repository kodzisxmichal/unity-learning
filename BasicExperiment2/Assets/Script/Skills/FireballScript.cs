using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballScript : MonoBehaviour
{

    [SerializeField] private float projectileSpeed = 1000f;

    void Start()
    {
        GetComponent<Rigidbody>().AddForce(transform.forward * projectileSpeed);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }


}
