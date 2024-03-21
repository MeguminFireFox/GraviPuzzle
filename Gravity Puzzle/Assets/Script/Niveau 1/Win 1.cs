using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win1 : MonoBehaviour
{
    public GameObject Panel;
    public bool _piece1 = false;
    public bool _piece2 = false;
    public bool _piece3 = false;
    public bool _piece4 = false;

    private Verif1 verif1;
    private Verif2 verif2;
    private Verif3 verif3;
    private Verif4 verif4;
    private float _time = 0;

    void FixedUpdate()
    {
        verif1 = FindObjectOfType<Verif1>();
        verif2 = FindObjectOfType<Verif2>();
        verif3 = FindObjectOfType<Verif3>();
        verif4 = FindObjectOfType<Verif4>();

        if ((verif1._pieces11 == true) || (verif1._pieces12 == true) || (verif1._pieces13 == true) || (verif1._pieces14 == true))
        {
            _piece1 = true;
        }
        else
        {
            _piece1 = false;
        }

        if ((verif2._pieces21 == true) || (verif2._pieces22 == true) || (verif2._pieces23 == true) || (verif2._pieces24 == true))
        {
            _piece2 = true;
        }
        else
        {
            _piece2 = false;
        }

        if ((verif3._pieces31 == true) || (verif3._pieces32 == true) || (verif3._pieces33 == true) || (verif3._pieces34 == true))
        {
            _piece3 = true;
        }
        else
        {
            _piece3 = false;
        }

        if ((verif4._pieces41 == true) || (verif4._pieces42 == true) || (verif4._pieces43 == true) || (verif4._pieces44 == true))
        {
            _piece4 = true;
        }
        else 
        {
            _piece4 = false;
        }

        if (_piece1 == true)
        {
            if (_piece2 == true)
            {
                if (_piece3 == true)
                {
                    if (_piece4 == true)
                    {
                        _time += Time.deltaTime;

                        if (_time >= 1)
                        {
                            Panel.SetActive(true);
                            Time.timeScale = 0;
                        }
                    }
                }
            }
        }
    }
}
