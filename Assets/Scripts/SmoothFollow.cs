using UnityEngine;
using System.Collections;

public class SmoothFollow : MonoBehaviour
{

    public Transform target;
    public float cameraSpeed = 15;
    public float yOffset = 22;
    public bool smoothFollow = true;

	// Update is called once per frame
	void FixedUpdate () 
    {
        if (target)
        {
            Vector3 newPos = transform.position;
            newPos.x = target.position.x;
            newPos.y = target.position.y - yOffset;

            if (!smoothFollow) transform.position = newPos;
            else transform.position = Vector3.Lerp(transform.position, newPos, cameraSpeed * Time.fixedDeltaTime);
        }
	
	}
}
