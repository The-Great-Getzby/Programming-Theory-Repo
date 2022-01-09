using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Shape
{
    // Start is called before the first frame update
    void Start()
    {
        shape = "Cube"; // set shape shape
        color = Color.red; // set shape color
        rotVector = new Vector3(0, 0, 1); // set shape rotation axis
        rotDegree = 45.0f; // set custom rotation amount. Can't be less than 45, per get/set validator in Shape class
        //greeting = "Howdy"; //can't change greeting sue to "private set" on greeting in Shape class
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
