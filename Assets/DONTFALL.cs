using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DONTFALL : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            transform.position = new Vector3(1, 1, 1);
        }
    }
}
