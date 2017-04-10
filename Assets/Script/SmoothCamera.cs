using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothCamera : MonoBehaviour {

    public Transform lookAt;

    private bool Smooth = true;
    private float SmoothSpeed = 0.125f;
    private Vector3 Offset = new Vector3(0,0,-30.5f);

	// Update is called once per frame
	private void LateUpdate ()
    {
        Vector3 DesiredPosition = lookAt.transform.position + Offset;
        if (Smooth)
        {
            transform.position = Vector3.Lerp(transform.position,DesiredPosition,SmoothSpeed);
        }
        else
        {
            transform.position = DesiredPosition;
        }
	}
}
