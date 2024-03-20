using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Vector3 zone;

    void OnTriggerEnter2D(Collider2D collision)
    {
        Pieces pieces = collision.GetComponent<Pieces>();

        if (pieces != null)
        {
            pieces.transform.position = zone;
        }
    }
}
