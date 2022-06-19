using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OmniDir //Creation of new class in order to do stuff
                    //when defining a class you are defining a new type like a int or struct
                    //new instances of your class are made by calling new memory and then your class name 
{
    
    

    private Vector3 m_direction;          //Vector3 is an object already created from Unity, in this case it is owned by OmniDir, we assigned the object to a variable or m_direction; m_direction has type vector3
    private KeyCode m_press;              //Same as above but with KeyCode; m_press has type KeyCode

    public OmniDir(KeyCode press, Vector3 direction) // making OmniDir constructor public solved a lot of errors; OmniDir is a constructor of the OmniDir class
    {                                               //initialized the constructor with the two object variables press and direction which are arguments


        m_press = press;                                //m_press is  member variable that is part of the move_l class, press is the argument that we pass from the list store function; we are assigning an argument to a variable
        m_direction = direction;                        //^^^ but with m_direction
    }


    public void move(Transform foo, float speed) //This function applies the changes to the player vectors that we want; recieving transform object from class movement and recieving float speed from class movement and naming them so they can be used in class OmniDir                                       
    {
        if (Input.GetKey(m_press)) //getkey requires a parameter so that it knows what look for what has been pressed, in this case it is looking at m_press which has 4 keys stored in it
        {
            foo.Translate(speed * m_direction * Time.deltaTime); //foo is the same transform object that is in the movement class that is inherited from monobehavior but we gave it a name when we passed it into move
           // foo.Rotate(speed * m_direction * Time.deltaTime);                                                     // translate is a function of transfrom and  we change the translate variables using speed * m_direction * time
        }
    }



}

public class Movement : MonoBehaviour
{
    public float speed = 2;



    // Start is called before the first frame update
    void Start()
    {
        list_store(); //at the beginning of the game we are calling list_store function 
    }

    // Update is called once per frame
    void Update()
    {

        transform.rotation = Quaternion.Euler(0, 0, 0); //this reads as rotation of the transform of the playerobject and it's setting its rotation to 0,0,0 i.e player lock 


      


        foreach (OmniDir i in movementList) //loop that iterates through size of movementList (4) by counting each move_L instance
        {
            i.move(transform, speed);//calling move function and passing through the transform object that is in class movement inherited from Monobehavior; passing float speed to move function
        }
       
    }
   
    List<OmniDir> movementList = new List<OmniDir>(); //created a list called movementList of type List<OmniDir>

    
    private void list_store() //This function is used to add OmniDir objects in the movementList list we created; note that the OmniDir objects are being added to the contsructor not neccesarily the class
    {
        movementList.Add(new OmniDir (KeyCode.W, Vector3.up));
        movementList.Add(new OmniDir (KeyCode.A, Vector3.left));
        movementList.Add(new OmniDir (KeyCode.S, Vector3.down));
        movementList.Add(new OmniDir (KeyCode.D, Vector3.right));
    }
   
   
}