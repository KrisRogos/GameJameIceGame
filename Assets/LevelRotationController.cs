using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelRotationController : MonoBehaviour {

    public float m_Speed = 1f;
    private Vector3 rotator;

    // Use this for initialization
    void Start () {
        rotator = new Vector3(m_Speed, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {
        if (!Application.isMobilePlatform)
            rotator.x = m_Speed * Input.GetAxis("Wheel Rotation");
        else
            rotator.x = m_Speed * Input.acceleration.x;

        transform.Rotate(rotator);
	}
}
