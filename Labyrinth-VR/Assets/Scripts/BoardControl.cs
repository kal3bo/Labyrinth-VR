using UnityEngine;

public class BoardControl : MonoBehaviour
{
    private Vector3 _CurrentRotation;

    // Update is called once per frame
    private void FixedUpdate()
    {
        _CurrentRotation = GetComponent<Transform>().eulerAngles;

        // Cases:
        if((Input.GetKey(KeyCode.W)) && (_CurrentRotation.x <= 20 || _CurrentRotation.x >= 338))
        {
            transform.Rotate(1, 0, 0);
        }

        else if ((Input.GetKey(KeyCode.S)) && (_CurrentRotation.x >= 339 || _CurrentRotation.x <= 21))
        {
            transform.Rotate(-1, 0, 0);
        }

        else if ((Input.GetKey(KeyCode.A)) && (_CurrentRotation.z <= 20 || _CurrentRotation.z >= 338))
        {
            transform.Rotate(0, 0, 1);
        }

        else if ((Input.GetKey(KeyCode.D)) && (_CurrentRotation.z >= 339 || _CurrentRotation.z <= 21))
        {
            transform.Rotate(0, 0, -1);
        }
    }
}
