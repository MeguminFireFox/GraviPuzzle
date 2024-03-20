using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEditor;
using UnityEngine;

public class Verif : MonoBehaviour
{
    public float Number;
    public Vector3 Small;
    public Vector3 Big;
    public bool P1 = false;
    public bool P2 = false;
    public bool P3 = false;
    public bool P4 = false;
    public bool P5 = false;
    public bool P6 = false;
    public bool P7 = false;
    public bool P8 = false;
    public bool P9 = false;

    void FixedUpdate()
    {
        Vector3 globalPosition = transform.position;
        Vector3 globalRotation = transform.eulerAngles;

        if (Number == 1)
        {
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

        if (Number == 2)
        {
            if (globalPosition.x >= Small.x && globalPosition.x <= Big.x)
            {
                if (globalPosition.y >= Small.y && globalPosition.y <= Big.y)
                {
                    if (globalRotation.z >= -10 && globalRotation.z <= 10)
                    {
                        P2 = true;
                    }
                    else
                    {
                        P2 = false;
                    }
                }
            }
        }

        if (Number == 3)
        {
            if (globalPosition.x >= Small.x && globalPosition.x <= Big.x)
            {
                if (globalPosition.y >= Small.y && globalPosition.y <= Big.y)
                {
                    if (globalRotation.z >= -10 && globalRotation.z <= 10)
                    {
                        P3 = true;
                    }
                    else
                    {
                        P3 = false;
                    }
                }
            }
        }

        if (Number == 4)
        {
            if (globalPosition.x >= Small.x && globalPosition.x <= Big.x)
            {
                if (globalPosition.y >= Small.y && globalPosition.y <= Big.y)
                {
                    if (globalRotation.z >= -10 && globalRotation.z <= 10)
                    {
                        P4 = true;
                    }
                    else
                    {
                        P4 = false;
                    }
                }
            }
        }

        if (Number == 5)
        {
            if (globalPosition.x >= Small.x && globalPosition.x <= Big.x)
            {
                if (globalPosition.y >= Small.y && globalPosition.y <= Big.y)
                {
                    if (globalRotation.z >= -10 && globalRotation.z <= 10)
                    {
                        P5 = true;
                    }
                    else
                    {
                        P5 = false;
                    }
                }
            }
        }

        if (Number == 6)
        {
            if (globalPosition.x >= Small.x && globalPosition.x <= Big.x)
            {
                if (globalPosition.y >= Small.y && globalPosition.y <= Big.y)
                {
                    if (globalRotation.z >= -10 && globalRotation.z <= 10)
                    {
                        P6 = true;
                    }
                    else
                    {
                        P6 = false;
                    }
                }
            }
        }

        if (Number == 7)
        {
            if (globalPosition.x >= Small.x && globalPosition.x <= Big.x)
            {
                if (globalPosition.y >= Small.y && globalPosition.y <= Big.y)
                {
                    if (globalRotation.z >= -10 && globalRotation.z <= 10)
                    {
                        P7 = true;
                    }
                    else
                    {
                        P7 = false;
                    }
                }
            }
        }

        if (Number == 8)
        {
            if (globalPosition.x >= Small.x && globalPosition.x <= Big.x)
            {
                if (globalPosition.y >= Small.y && globalPosition.y <= Big.y)
                {
                    if (globalRotation.z >= -10 && globalRotation.z <= 10)
                    {
                        P8 = true;
                    }
                    else
                    {
                        P8 = false;
                    }
                }
            }
        }

        if (Number == 9)
        {
            if (globalPosition.x >= Small.x && globalPosition.x <= Big.x)
            {
                if (globalPosition.y >= Small.y && globalPosition.y <= Big.y)
                {
                    if (globalRotation.z >= -10 && globalRotation.z <= 10)
                    {
                        P9 = true;
                    }
                    else
                    {
                        P9 = false;
                    }
                }
            }
        }
    }
}