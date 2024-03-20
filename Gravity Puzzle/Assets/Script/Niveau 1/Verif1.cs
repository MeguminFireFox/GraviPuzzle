using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Verif1 : MonoBehaviour
{

    public bool _pieces11 = false;
    public bool _pieces12 = false;
    public bool _pieces13 = false;
    public bool _pieces14 = false;

    void FixedUpdate()
    {
        Vector3 globalPosition = transform.position;
        Vector3 globalRotation = transform.eulerAngles;

        if (globalPosition.x >= 0.4 && globalPosition.x <= 0.8)
        {
            if (globalPosition.y >= -4.7 && globalPosition.y <= -4.3)
            {
                if (globalRotation.z >= -10 && globalRotation.z <= 10)
                {
                    _pieces11 = true;
                }
                else
                {
                    _pieces11 = false;
                    OnDeux();
                }
            }
            else
            {
                _pieces11 = false;
                OnDeux();
            }
        }
        else
        {
            _pieces11 = false;
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
                if (globalRotation.z >= 80 && globalRotation.z <= 100)
                {
                    _pieces12 = true;
                }
                else
                {
                    _pieces12 = false;
                    OnTrois();
                }
            }
            else
            {
                _pieces12 = false;
                OnTrois();
            }
        }
        else
        {
            _pieces12 = false;
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
                if ((globalRotation.z <= -170 && globalRotation.z >= -190) || (globalRotation.z >= 170 && globalRotation.z <= 190))
                {
                    _pieces13 = true;
                }
                else
                {
                    _pieces13 = false;
                    OnQuatre();
                }
            }
            else
            {
                _pieces13 = false;
                OnQuatre();
            }
        }
        else
        {
            _pieces13 = false;
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
                if ((globalRotation.z <= -80 && globalRotation.z >= -100) || (globalRotation.z >= 260 && globalRotation.z <= 280))
                {
                    _pieces14 = true;
                }
                else
                {
                    _pieces14 = false;
                }
            }
            else
            {
                _pieces14 = false;
            }
        }
        else
        {
            _pieces14 = false;
        }
    }
}