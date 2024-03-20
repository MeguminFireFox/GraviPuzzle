using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Verif2 : MonoBehaviour
{

    public bool _pieces21 = false;
    public bool _pieces22 = false;
    public bool _pieces23 = false;
    public bool _pieces24 = false;

    void FixedUpdate()
    {
        Vector3 globalPosition = transform.position;
        Vector3 globalRotation = transform.eulerAngles;

        if (globalPosition.x >= 0.4 && globalPosition.x <= 0.8)
        {
            if (globalPosition.y >= -4.7 && globalPosition.y <= -4.3)
            {
                if ((globalRotation.z <= -80 && globalRotation.z >= -100) || (globalRotation.z >= 260 && globalRotation.z <= 280))
                {
                    _pieces21 = true;
                }
                else
                {
                    _pieces21 = false;
                    OnDeux();
                }
            }
            else
            {
                _pieces21 = false;
                OnDeux();
            }
        }
        else
        {
            _pieces21 = false;
            OnDeux();
        }
    }

    void OnDeux()
    {
        Vector3 globalPosition = transform.position;
        Vector3 globalRotation = transform.eulerAngles;

        if (globalPosition.x >= 0.4 && globalPosition.x <= 0.8)
        {
            if (globalPosition.y >= -3.7 && globalPosition.y <= -3.3)
            {
                if (globalRotation.z >= -10 && globalRotation.z <= 10)
                {
                    _pieces22 = true;
                }
                else
                {
                    _pieces22 = false;
                    OnTrois();
                }
            }
            else
            {
                _pieces22 = false;
                OnTrois();
            }
        }
        else
        {
            _pieces22 = false;
            OnTrois();
        }
    }

    void OnTrois()
    {
        Vector3 globalPosition = transform.position;
        Vector3 globalRotation = transform.eulerAngles;

        if (globalPosition.x <= -0.4 && globalPosition.x >= -0.8)
        {
            if (globalPosition.y >= -3.7 && globalPosition.y <= -3.3)
            {
                if (globalRotation.z >= 80 && globalRotation.z <= 100)
                {
                    _pieces23 = true;
                }
                else
                {
                    _pieces23 = false;
                    OnQuatre();
                }
            }
            else
            {
                _pieces23 = false;
                OnQuatre();
            }
        }
        else
        {
            _pieces23 = false;
            OnQuatre();
        }
    }

    void OnQuatre()
    {
        Vector3 globalPosition = transform.position;
        Vector3 globalRotation = transform.eulerAngles;

        if (globalPosition.x <= -0.4 && globalPosition.x >= -0.8)
        {
            if (globalPosition.y >= -4.7 && globalPosition.y <= -4.3)
            {
                if ((globalRotation.z <= -170 && globalRotation.z >= -190) || (globalRotation.z >= 170 && globalRotation.z <= 190))
                {
                    _pieces24 = true;
                }
                else
                {
                    _pieces24 = false;
                }
            }
            else
            {
                _pieces24 = false;
            }
        }
        else
        {
            _pieces24 = false;
        }
    }
}