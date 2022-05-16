using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public float speed = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKey(KeyCode.A))
        {
            gameObject.transform.Translate(speed * Vector3.left * Time.deltaTime);
        }
       if (Input.GetKey(KeyCode.W))
        {
            gameObject.transform.Translate(speed * Vector3.up * Time.deltaTime);
        }
       if (Input.GetKey(KeyCode.S))
        {
            gameObject.transform.Translate(speed * Vector3.down * Time.deltaTime);
        }
       if (Input.GetKey(KeyCode.D))
        {
            gameObject.transform.Translate(speed * Vector3.right * Time.deltaTime);
        }
    }
}
