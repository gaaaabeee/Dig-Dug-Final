using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hose : MonoBehaviour
{

    public GameObject HoseTemp;
    GameObject TempHose;
    

    // Update is called once per frame
    void Update()
    {
        HoseAtt();
    }


    public void HoseAtt ()
    {
        if (Input.GetKeyDown("space"))
        {
           TempHose = Instantiate(HoseTemp, gameObject.transform);
        }
        else if (Input.GetKeyUp("space"))
        {
            Destroy(TempHose);
        }
    }

}