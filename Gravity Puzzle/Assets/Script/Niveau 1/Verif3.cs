using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Verif3 : MonoBehaviour
{

    public bool _pieces31 = false;
    public bool _pieces32 = false;
    public bool _pieces33 = false;
    public bool _pieces34 = false;

    void FixedUpdate()
    {
        Vector3 globalPosition = transform.position;
        Vector3 globalRotation = transform.eulerAngles;

        if (globalPosition.x >= 0.4 && globalPosition.x <= 0.8)
        {
            if (globalPosition.y >= -4.7 && globalPosition.y <= -4.3)
            {
                if ((globalRotation.z <= -170 && globalRotation.z >= -190) || (globalRotation.z >= 170 && globalRotation.z <= 190))
                {
                    _pieces31 = true;
                }
                else
                {
                    _pieces31 = false;
                    OnDeux();
                }
            }
            else
            {
                _pieces31 = false;
                OnDeux();
            }
        }
        else
        {
            _pieces31 = false;
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
                if ((globalRotation.z <= -80 && globalRotation.z >= -100) || (globalRotation.z >= 260 && globalRotation.z <= 280))
                {
                    _pieces32 = true;
                }
                else
                {
                    _pieces32 = false;
                    OnTrois();
                }
            }
            else
            {
                _pieces32 = false;
                OnTrois();
            }
        }
        else
        {
            _pieces32 = false;
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
                if (globalRotation.z >= -10 && globalRotation.z <= 10)
                {
                    _pieces33 = true;
                }
                else
                {
                    _pieces33 = false;
                    OnQuatre();
                }
            }
            else
            {
                _pieces33 = false;
                OnQuatre();
            }
        }
        else
        {
            _pieces33 = false;
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
                if (globalRotation.z >= 80 && globalRotation.z <= 100)
                {
                    _pieces34 = true;
                }
                else
                {
                    _pieces34 = false;
                }
            }
            else
            {
                _pieces34 = false;
            }
        }
        else
        {
            _pieces34 = false;
        }
    }
}