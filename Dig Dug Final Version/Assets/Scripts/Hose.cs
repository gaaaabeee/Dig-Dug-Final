using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hose : MonoBehaviour
{

    public GameObject HoseTemp; //initalize gameobject called Hosetemp; public so you can use in inspector
    GameObject TempHose; //initalize other gameobject called tempHose; not public so local only to class Hose
    

    // Update is called once per frame
    void Update()
    {
        HoseAtt(); //calls HoseAtt func
    }

    public void HoseAtt () //func HoseAtt; doesn't return anything hence void
    {
        if (Input.GetKeyDown("space")) //if keypress is space commit action
        {
           TempHose = Instantiate(HoseTemp, gameObject.transform); // create (instantiate) gameobject hosetemp and (set its transform to the same as the gameobject of the player) then set this to tempHose gameobject
        }
        else if (Input.GetKeyUp("space")) //else if keypress space is released
        {
            Destroy(TempHose); //destroy TempHose gameobject
        }
    }


    //Purpose of this script is to create "weapon" on keypress and get rid of it when keypress is released 
    //the reason I needed another gameobject was because the destroy function quite literally destroys the enitere game object
    // so I needed a clone version that I could recreate and destroy every time 
    //not sure if this is the most efficient way of dealing with this 
}