using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer renderer;
    Rigidbody rigidbody;
    
    [SerializeField] float timeToWait = 5f;

    // Start is called before the first frame update
    void Start()
    {
        // This is called caching a reference: storing frequently used data/information in memeory,  
        // so that it can easily be accessed when needed.
        renderer = GetComponent<MeshRenderer>();
        rigidbody = GetComponent<Rigidbody>();

        renderer.enabled = false;
        rigidbody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > timeToWait){
            renderer.enabled = true;
            rigidbody.useGravity = true;
        }
    }
}
