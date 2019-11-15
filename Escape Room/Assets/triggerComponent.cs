using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerComponent : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {

        print(other.gameObject.name + " has entered the trigger.");
        GetComponent<Renderer>().material.color = Color.green;
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}