using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Control_Velocity : MonoBehaviour
{
    [SerializeField]
    Vector3 v3Force;
    
    [SerializeField]
    KeyCode Keypositive;
    [SerializeField]
    KeyCode Keynegative;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(Keypositive))
            GetComponent<Rigidbody>().velocity += v3Force;
        

         if (Input.GetKey(Keynegative))
            GetComponent<Rigidbody>().velocity -= v3Force;
    
        
    }
}
