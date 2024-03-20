using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pieces : MonoBehaviour
{
    public Vector3 positionDepart;
    public Rigidbody2D Rb;
    public Transform Haut;
    public Transform Bas;
    public Transform Droite;
    public Transform Gauche;
    public bool Active = false;
    private float _forceAmount = 15;

    void Start()
    {
        positionDepart = transform.position;
    }

    void OnMouseDown()
    {
        Active = true;
    }

    void OnMouseUp()
    {
        Active = false;
    }

    void FixedUpdate()
    {
        if (Active == true)
        {
            if (Input.GetKey("w"))
            {
                Rb.AddForce(Haut.position * _forceAmount * Time.deltaTime);
            }

            if (Input.GetKey("s"))
            {
                Rb.AddForce(Bas.position * _forceAmount * Time.deltaTime);
            }

            if (Input.GetKey("d"))
            {
                Rb.AddForce(Droite.position * _forceAmount * Time.deltaTime);
            }

            if (Input.GetKey("a"))
            {
                Rb.AddForce(Gauche.position * _forceAmount * Time.deltaTime);
            }
        }
    }
}
