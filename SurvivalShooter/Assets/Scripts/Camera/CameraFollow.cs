using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	public Transform target;
	public float smoothing = 5f;

	Vector3 offset;

	void Start()
	{
		//transform befing the camera, target being the player, offset being the set distance btwn 2
		offset = transform.position - target.position;
	}

	void FixedUpdate()
	{
		Vector3 targetCamPos = target.position + offset;
		// lerp
		transform.position = Vector3.Lerp (transform.position, targetCamPos, smoothing *Time.deltaTime);
	}

}
