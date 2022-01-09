using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

 public class Shape : MonoBehaviour // Shape will be the base class for all other "shape" classes
{

    protected string shape; // a shape's shape
    protected string greeting { get; private set; } = "Hello"; // a shape's greeting, starts off the debug log display
    protected Color color; // a shape's color
    protected Vector3 rotVector; // a Shape's rotation axis
    private float m_rotDegree = 90.0f; // a shape's rotation amount
    public float rotDegree
    {
        get { return m_rotDegree; }
        set
        {
            if (value < 45.0f)
            {
                Debug.LogError("You can't have a rotation amount less than 45 degrees!");
            }
            else
            {
                m_rotDegree = value;
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnMouseDown() // built in method that checks when a mouse is clicked inside a collider
    {
        ShapeSpeak(); // fire custom method
    }

    public virtual void ShapeSpeak() // custom method
    {
        transform.Rotate(rotVector, rotDegree); // rotate the shape
        Debug.Log($"{greeting}, I'm a {shape}! My color is {color}."); // print a statement to the debug log
    }

}
