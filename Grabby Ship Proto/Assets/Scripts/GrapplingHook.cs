using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrapplingHook : MonoBehaviour
{
    public GameObject hook;
    public GameObject hookHolder;

    public float hookTravelSpeed;
    public float playerTravelSpeed;

    public static bool hookFired;
    public static bool hookAttached;

    public float maxDistance;
    private float currentDistance;

    private void Update()
    {
        if(Input.GetMouseButtonDown(0) && hookFired == false)
        {
            hookFired = true;
        }

        if (hookFired == true)
        {
            hook.transform.Translate(Vector3.forward * Time.deltaTime * hookTravelSpeed);
            currentDistance = Vector3.Distance(transform.position, hook.transform.position);

            if (currentDistance >= maxDistance)
                ReturnHook();

        }
    }

    void ReturnHook()
    {
        hook.transform.position = hookHolder.transform.position;
    }
}

