using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthScript : MonoBehaviour
{
    [SerializeField] public float healthPoints;
    [SerializeField] Slider HPslider;

    private void Start()
    {   
        // setting max hp in healthbar
        HPslider.maxValue = healthPoints;

        HPslider.transform.position = GetComponent<Transform>().position + Vector3.up;
    }

    void Update()
    {
        HPslider.value = healthPoints;

        if (healthPoints <= 0)
        {

            Death();
        }
    }

    private void Death()
    {
        Destroy(gameObject);
    }
}
