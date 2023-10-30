using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{

    public bool test;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Hit! Trigger");
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Hit! Trigger");
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Hit! Trigger");
    }


    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Hit! Collision");
    }

    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("Hit! Collision");
    }

    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("Hit! Collision");
    }
}
