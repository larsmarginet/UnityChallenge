using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverAnimation : MonoBehaviour
{
    public float degreesPerSecond = 1.0f;
    public float amplitude = 1.0f;
    public float frequency = 1.0f;

    // Position Storage Variables
    Vector3 posOffset = new Vector3();
    Vector3 tempPos = new Vector3();

    // Use this for initialization
    void Start()
    {
        // Store the starting position & rotation of the object
        posOffset = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // Spin object around Y-Axis
        transform.Rotate(new Vector3(Time.deltaTime * degreesPerSecond, Time.deltaTime * degreesPerSecond, Time.deltaTime * degreesPerSecond), Space.World);

        // Float up/down with a Sin()
        tempPos = posOffset;
        tempPos.y += Mathf.Sin(Time.fixedTime * Mathf.PI * frequency) * amplitude;

        transform.position = tempPos;
    }
}
