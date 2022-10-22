using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttackScript : MonoBehaviour
{
    [SerializeField] GameObject fireballPrefab;
    [SerializeField] Transform spawnPosition;
    [SerializeField] Transform spawnRotation;

    [SerializeField] private float projectileSpeed = 100f;
    [SerializeField] private KeyCode fireb_key;

    

    void Start()
    {
        
    }

  
    void Update()
    {
        if (Input.GetKeyDown(fireb_key))
        {
            Fireball();
        }
    }

    private void Fireball()
    {
        Instantiate(fireballPrefab, spawnPosition.position, spawnRotation.rotation);
    }
}
