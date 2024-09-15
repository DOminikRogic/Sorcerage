using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Earth : MonoBehaviour
{

    public GameObject lowWall;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            Instantiate(lowWall, gameObject.transform.position, gameObject.transform.rotation);
            lowWall.AddComponent<BoxCollider>();
        }
    }
}
