using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Verif4 : MonoBehaviour
{

    public bool _pieces41 = false;
    public bool _pieces42 = false;
    public bool _pieces43 = false;
    public bool _pieces44 = false;

    void FixedUpdate()
    {
        Vector3 globalPosition = transform.position;
        Vector3 globalRotation = transform.eulerAngles;

        if (globalPosition.x >= 0.3 && globalPosition.x <= 0.9)
        {
            if (globalPosition.y >= -4.8 && globalPosition.y <= -4.2)
            {
                if (globalRotation.z >= 80 && globalRotation.z <= 100)
                {
                    _pieces41 = true;
                }
                else
                {
                    _pieces41 = false;
                    OnDeux();
                }
            }
            else
            {
                _pieces41 = false;
                OnDeux();
            }
        }
        else
        {
            _pieces41 = false;
            OnDeux();
        }
    }

    void OnDeux()
    {
        Vector3 globalPosition = transform.position;
        Vector3 globalRotation = transform.eulerAngles;

        if (globalPosition.x >= 0.3 && globalPosition.x <= 0.9)
        {
            if (globalPosition.y >= -3.8 && globalPosition.y <= -3.2)
            {
                if ((globalRotation.z <= -170 && globalRotation.z >= -190) || (globalRotation.z >= 170 && globalRotation.z <= 190))
                {
                    _pieces42 = true;
                }
                else
                {
                    _pieces42 = false;
                    OnTrois();
                }
            }
            else
            {
                _pieces42 = false;
                OnTrois();
            }
        }
        else
        {
            _pieces42 = false;
            OnTrois();
        }
    }

    void OnTrois()
    {
        Vector3 globalPosition = transform.position;
        Vector3 globalRotation = transform.eulerAngles;

        if (globalPosition.x <= -0.3 && globalPosition.x >= -0.9)
        {
            if (globalPosition.y >= -3.8 && globalPosition.y <= -3.2)
            {
                if ((globalRotation.z <= -80 && globalRotation.z >= -100) || (globalRotation.z >= 260 && globalRotation.z <= 280))
                {
                    _pieces43 = true;
                }
                else
                {
                    _pieces43 = false;
                    OnQuatre();
                }
            }
            else
            {
                _pieces43 = false;
                OnQuatre();
            }
        }
        else
        {
            _pieces43 = false;
            OnQuatre();
        }
    }

    void OnQuatre()
    {
        Vector3 globalPosition = transform.position;
        Vector3 globalRotation = transform.eulerAngles;

        if (globalPosition.x <= -0.3 && globalPosition.x >= -0.9)
        {
            if (globalPosition.y >= -4.8 && globalPosition.y <= -4.2)
            {
                if (globalRotation.z >= -10 && globalRotation.z <= 10)
                {
                    _pieces44 = true;
                }
                else
                {
                    _pieces44 = false;
                }
            }
            else
            {
                _pieces44 = false;
            }
        }
        else
        {
            _pieces44 = false;
        }
    }
}