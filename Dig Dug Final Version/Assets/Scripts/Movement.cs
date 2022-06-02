using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_L //Creation of new class in order to do stuff
                    //when defining a class you are defining a new type like a int or struct
                    //new instances of your class are made by calling new memory and then your class name 
{
    private float speed = 2;

    private Vector3 m_direction;          //Vector3 is an object already created from Unity, in this case it is owned by Move_L, we assigned the object to a variable or m_direction; m_direction has type vector3
    private KeyCode m_press;              //Same as above but with KeyCode; m_press has type KeyCode

    public Move_L(KeyCode press, Vector3 direction) // making Move_L constructor public solved a lot of errors; Move_L is a constructor of the Move_L class
    {                                               //initialized the constructor with the two object variables press and direction which are arguments


        m_press = press;                                //m_press is  member variable that is part of the move_l class, press is the argument that we pass from the list store function; we are assigning an argument to a variable
        m_direction = direction;                        //^^^ but with m_direction
    }


    public void shmoove(Transform foo) //I think making this function public solved an error; This function applies the changes to the player vectors that we want; 
    {
        if (Input.GetKey(m_press)) //getkey requires a parameter so that it knows what look for what has been pressed, in this case it is looking at m_press which has 4 keys stored in it
        {
            foo.Translate(speed * m_direction * Time.deltaTime); //foo is the same transform object that is in the movement class that is inherited from monobehavior but we gave it a name when we passed it into shmoove
                                                                 // translate is a function of transfrom and  we change the translate variables using speed * m_direction * time
        }
    }



}

public class Movement : MonoBehaviour
{



    
    // Start is called before the first frame update
    void Start()
    {
        list_store(); //at the beginning of the game we are calling list_store function 
    }

    // Update is called once per frame
    void Update()
    {

        transform.rotation = Quaternion.Euler(0, 0, 0); //this reads as rotation of the transform of the playerobject and it's setting its rotation to 0,0,0 i.e player lock 

        foreach(Move_L i in nice) //loop that iterates through size of nice (4) by counting each move_L instance
        {
            i.shmoove(transform);//calling shmoove function and passing through the transform object that is in class movement inherited from Monobehavior
        }
       
    }
   
    List<Move_L> nice = new List<Move_L>(); //created a list called nice of type List<Move_L>

    
    public void list_store() //not sure if making this public did anything; This function is used to add Move_L objects in the nice list we created; note that the Move_L objects are being added to the contsructor not neccesarily the class
    {
        nice.Add(new Move_L(KeyCode.W, Vector3.up));
        nice.Add(new Move_L(KeyCode.A, Vector3.left));
        nice.Add(new Move_L(KeyCode.S, Vector3.down));
        nice.Add(new Move_L(KeyCode.D, Vector3.right));
    }
   
   
}