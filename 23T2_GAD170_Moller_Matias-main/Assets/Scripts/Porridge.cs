using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Porridge : MonoBehaviour
{
    [SerializeField] private float  temperature;

    private void Start()
    {
        temperature = 100;
    }

    private void Update()
    {
        temperature = temperature - Time.deltaTime; 

        if(temperature > 70)
        {
            Debug.Log("The Temperature is too hot" + (int)temperature);
        }

       else if(temperature < 40)
        {
            Debug.Log("The Temperature is too cold" + (int)temperature);
        }

       else
        {
            Debug.Log("The Temperature is just right" + (int)temperature);
        }

     
    }
}
