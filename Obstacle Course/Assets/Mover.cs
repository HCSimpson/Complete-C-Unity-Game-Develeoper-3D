using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    //Serialize Field allows you to edit the value from inside Unity UI.
    [SerializeField] float xValue = 0;
    [SerializeField] float yValue = 0.01f;
    [SerializeField] float zValue = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Input allows you to access Input Manager and the methods inside it.
        float xValue = Input.GetAxis("Horizontal");
        float zValue = Input.GetAxis("Vertical");
        
        transform.Translate(xValue, 0, zValue);
    }
}
