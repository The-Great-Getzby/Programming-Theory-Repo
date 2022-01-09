using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule : Shape //INHERITANCE
{
    // Start is called before the first frame update
    void Start()
    {
        shape = "Capsule"; // set shape shape
        color = Color.green; // set shape color
        rotVector = new Vector3(0, 0, 1); // set shape rotation axis
    }

    // Update is called once per frame
    void Update()
    {
     
    }

    //public override void ShapeSpeak()
    //{
        //Debug.Log($"Howdy, I'm a {shape}! My color is {color}");
    //}


}
