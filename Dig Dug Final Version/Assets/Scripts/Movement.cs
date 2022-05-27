using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{



    
    // Start is called before the first frame update
    void Start()
    {
        list_store();
    }

    // Update is called once per frame
    void Update()
    {

        transform.rotation = Quaternion.Euler(0, 0, 0);

        foreach(Move_L i in nice)
        {
            i.shmoove();
        }
       
    }


  

    public class Move_L //Creation of new class in order to do stuff, similar to a struct need to ask Read why we did this  or moreover what is purpose is
    {
        public float speed = 2;
        public Vector3 m_direction;          //Vector3 is an object already created from Unity, I think it belongs to MonoBehavior, we assigned the object to a variable
        public KeyCode m_press;              //Same as above but with KeyCode
        
        public Move_L(KeyCode press, Vector3 direction) // making Move_L constructor public solved a lot of errors don't know if making vector3 var and KeyCode var public did anything; Move_L is a constructor of the Move_L class
        {                                               //initialized the constructor with the two object variables
            m_press = press;
            m_direction = direction;
        }

        
        public void shmoove() //I think making this function public solved an error; This function applies the changes to the player vectors that we want
        {
            if (Input.GetKey(m_press))
            {
                gameObject.transform.Translate(speed * m_direction * Time.deltaTime);
            }
        }



    }

    List<Move_L> nice = new List<Move_L>(); //create a list

    
    public void list_store() //not sure if making this public did anything; This function is used to store things in the nice list we created
    {
        nice.Add(new Move_L(KeyCode.W, Vector3.up));
        nice.Add(new Move_L(KeyCode.A, Vector3.left));
        nice.Add(new Move_L(KeyCode.S, Vector3.down));
        nice.Add(new Move_L(KeyCode.D, Vector3.right));
    }
   
   
}