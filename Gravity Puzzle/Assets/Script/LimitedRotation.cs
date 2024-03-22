using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimitedRotation : MonoBehaviour
{
    public float Speed;
    public Vector3 rotatiodirection1 = new Vector3();
    public Vector3 rotatiodirection2 = new Vector3();
    private float Currenttime = 0;
    public float timechoice1 = 0;
    public float timechoice2 = 0;

    void FixedUpdate()
    {
        Currenttime += Time.deltaTime;

        if (Time.deltaTime <= timechoice1)
        {
            transform.Rotate(Speed * rotatiodirection1 * Time.deltaTime);
        }
        else
        {
            if (Time.deltaTime <= timechoice2)
            {
                transform.Rotate(Speed * rotatiodirection2 * Time.deltaTime);
            }
            else
            {
                Currenttime = 0;
            }
        }
    }
}
