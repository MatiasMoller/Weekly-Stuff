using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GameManager : MonoBehaviour

{
    // Reference all the cars in the game

    [SerializeField] private Car[] cars;
    [SerializeField] private List<Car> carsList = new List<Car>();
    
    
    void Start()
    {
        Debug.Log(cars.Length);
        Debug.Log(carsList[0].name);

        Debug.Log(carsList.Count);
        Debug.Log(carsList[0].name); 
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            CheckWhichCarIsCrashed();   
        }
    }
    private void CheckWhichCarIsCrashed()
    {
        for (int selectedCarIndex = 0; selectedCarIndex < cars.Length; selectedCarIndex++)
        {
            if (carsList[selectedCarIndex].isCrashed ==true)
                Debug.Log("crashed bozo" + selectedCarIndex);
                Debug.Log("A car has crashed: [" + carsList[selectedCarIndex].name + "]!");
        }
        
    }
    // Update is called once per frame
    public void HelloWorldButton()
    {
        Debug.Log("Hello Owrld from a UI Button");

    }
}
