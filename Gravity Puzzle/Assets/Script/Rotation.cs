using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float Speed;
    public Vector3 rotatiodirection = new Vector3();

    void FixedUpdate()
    {
        transform.Rotate(Speed * rotatiodirection * Time.deltaTime);
    }
}
