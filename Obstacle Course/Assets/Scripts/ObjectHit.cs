using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    //OnCollisionEnter is a callback method that is triggered when two box colliders touch.
    private void OnCollisionEnter(Collision other) {
        GetComponent<MeshRenderer>().material.color = Color.red;
    }
}
