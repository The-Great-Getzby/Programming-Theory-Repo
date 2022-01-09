using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder : Shape
{
    // Start is called before the first frame update
    void Start()
    {
        shape = "Cylinder"; // set shape shape
        color = Color.blue; // set shape color
        rotVector = new Vector3(1, 0, 0); // set shape rotation axis (shape is pre-rotated)
        rotDegree = 45.0f; // set custom rotation amount. Can't be less than than 45, per get/set validator in Shape class
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void ShapeSpeak() // override method for custom debug log message
    {
        transform.Rotate(rotVector, rotDegree);
        Debug.Log($"Don't listen! I may look like a {shape}, but it's a lie! My color isn't even {color}!");
    }
}
