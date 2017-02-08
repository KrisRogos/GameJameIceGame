using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelRotationController : MonoBehaviour {

    public float m_Speed = 1f;
    private float rotator;

    // Use this for initialization
    void Start () {
        rotator = 0;
	}
	
	// Update is called once per frame
	void Update () {
        if (!Application.isMobilePlatform)
            rotator = m_Speed * Input.GetAxis("Wheel Rotation");
        else
            rotator = m_Speed * Input.acceleration.x;

        transform.RotateAround(new Vector3(0f, 0f, 0f), new Vector3(0f, 0f, 1f), rotator);
	}
}
