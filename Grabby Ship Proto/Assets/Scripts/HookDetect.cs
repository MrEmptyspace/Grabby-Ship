using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HookDetect : MonoBehaviour
{
    public GameObject player;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Hookable")
        {
            player.GetComponent<GrapplingHook>().hookAttached = true;
            player.GetComponent<GrapplingHook>().hookedObj = other.gameObject;

        }
    }
}
