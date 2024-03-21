using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Verif28 : MonoBehaviour
{
    public Vector3 Small;
    public Vector3 Big;
    public bool P1 = false;

    void FixedUpdate()
    {
        Vector3 globalPosition = transform.position;
        Vector3 globalRotation = transform.eulerAngles;

        if (globalPosition.x >= Small.x && globalPosition.x <= Big.x)
        {
            if (globalPosition.y >= Small.y && globalPosition.y <= Big.y)
            {
                if (globalRotation.z >= -10 && globalRotation.z <= 10)
                {
                    P1 = true;
                }
                else
                {
                    P1 = false;
                }
            }
        }
    }
}