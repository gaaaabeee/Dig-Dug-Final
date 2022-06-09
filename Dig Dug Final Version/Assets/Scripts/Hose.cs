using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hose : MonoBehaviour
{

    public GameObject HoseTemp;

    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            Instantiate(HoseTemp, gameObject.transform);        
        }
    }
}
