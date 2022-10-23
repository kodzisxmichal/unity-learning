using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballScript : MonoBehaviour
{

    [SerializeField] private float projectileSpeed = 1f;
    [SerializeField] public float spellDamage = 1;


    void Start()
    {
        GetComponent<Rigidbody>().AddForce(transform.forward * projectileSpeed * 10f);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Enemy")
        {
            collision.gameObject.GetComponent<HealthScript>().healthPoints -= spellDamage;
        }
        
        Destroy(gameObject);
    }


}
