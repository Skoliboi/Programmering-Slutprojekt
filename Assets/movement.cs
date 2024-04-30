using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public int Hopp;
    
    Rigidbody myRigidbody;
    // Start is called before the first frame update
   public void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();

        Hopp = 0;
       
    }

    // Update is called once per frame
     void Update()
    {
        
        
        if (Input.GetKey(KeyCode.D))
        {
            myRigidbody.AddForce(new Vector3(5, 0, 0));
        }
        if (Input.GetKey(KeyCode.A))
        {
            myRigidbody.AddForce(new Vector3(-5, 0, 0));
        }
        if (Input.GetKeyDown(KeyCode.W) && Hopp < 1)
        {
            myRigidbody.AddForce(new Vector3(0, 240, 0));
            Hopp++;
        }
        if(Input.GetKeyDown(KeyCode.E) && Hopp < 1)
        {
            myRigidbody.AddForce(new Vector3(240, 240, 0));
            Hopp++;
        }
        if (Input.GetKeyDown(KeyCode.Q) && Hopp < 1)
        {
            myRigidbody.AddForce(new Vector3(-240, 240, 0));
            Hopp++;
        }
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (Hopp > 0)
        {
            Hopp--;
        }
        Debug.Log(Hopp);
    }
}
