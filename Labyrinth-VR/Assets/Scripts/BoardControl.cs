using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardControl : MonoBehaviour
{
    public Vector3 _CurrentRotation;

    // Update is called once per frame
    void FixedUpdate()
    {
        _CurrentRotation = GetComponent<Transform>().eulerAngles;

        // Cases:
        if((Input.GetKey(KeyCode.W)) && (_CurrentRotation.z <= 10 || _CurrentRotation.z >= 348))
        {
            transform.Rotate(1, 0, 0);
        }

        if ((Input.GetKey(KeyCode.S)) && (_CurrentRotation.z >= 349 || _CurrentRotation.z <= 11))
        {
            transform.Rotate(-1, 0, 0);
        }
    }
}
