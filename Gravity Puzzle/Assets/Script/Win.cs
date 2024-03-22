using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
    public bool Puzzle4;
    public bool Puzzle6;
    public bool Puzzle9;
    public GameObject panel;

    private bool _cbon;

    void FixedUpdate()
    {
        if (Puzzle4 == true)
        {
            OnUn();
        }

        if (Puzzle6 == true)
        {
            OnDeux();
        }

        if (Puzzle9 == true)
        {
            OnTrois();
        }

        if (_cbon == true)
        {
            Time.timeScale = 0;
            panel.SetActive(true);
        }
    }

    void OnUn()
    {
        Verif21 verif21 = FindObjectOfType<Verif21>();
        Verif22 verif22 = FindObjectOfType<Verif22>();
        Verif23 verif23 = FindObjectOfType<Verif23>();

        if (verif21.P1 == true && verif22.P1 == true && verif23.P1 == true)
        {
            _cbon = true;
        }
    }

    void OnDeux()
    {
        Verif21 verif21 = FindObjectOfType<Verif21>();
        Verif22 verif22 = FindObjectOfType<Verif22>();
        Verif23 verif23 = FindObjectOfType<Verif23>();
        Verif24 verif24 = FindObjectOfType<Verif24>();
        Verif25 verif25 = FindObjectOfType<Verif25>();

        if (verif21.P1 == true && verif22.P1 == true && verif23.P1 == true && verif24.P1 == true && verif25 == true)
        {
            _cbon = true;
        }
    }

    void OnTrois()
    {
        Verif21 verif21 = FindObjectOfType<Verif21>();
        Verif22 verif22 = FindObjectOfType<Verif22>();
        Verif23 verif23 = FindObjectOfType<Verif23>();
        Verif24 verif24 = FindObjectOfType<Verif24>();
        Verif25 verif25 = FindObjectOfType<Verif25>();
        Verif26 verif26 = FindObjectOfType<Verif26>();
        Verif27 verif27 = FindObjectOfType<Verif27>();
        Verif28 verif28 = FindObjectOfType<Verif28>();

        if (verif21.P1 == true && verif22.P1 == true && verif23.P1 == true && verif24.P1 == true && verif25 == true && verif26.P1 == true && verif27.P1 == true && verif28.P1 == true)
        {
            _cbon = true;
        }
    }
}
