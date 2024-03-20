using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laserrrrrr : MonoBehaviour
{
    [SerializeField] private float defDistanceRay = 100;
    public Transform laserFirePoint;
    public LineRenderer m_lineRenderer;
    Transform m_transform;

    void Awake()
    {
        m_transform = GetComponent<Transform>();
    }

    private void Update()
    {
        ShootLaser();
    }

    void ShootLaser()
    {
        Pieces pieces = FindObjectOfType<Pieces>();
        RaycastHit2D hit = Physics2D.Raycast(laserFirePoint.position, transform.right, defDistanceRay);
        if (hit.collider != null)
        {
            Draw2DRay(laserFirePoint.position, hit.point);
            // Vous pouvez ajouter ici le code pour réagir à la collision avec l'objet détecté.
            if (hit.collider.CompareTag("piece"))
            {
                Pieces piece = hit.collider.GetComponent<Pieces>();
                if (piece != null)
                {
                    piece.transform.position = piece.positionDepart;
                }
            }
        }
        else
        {
            Draw2DRay(laserFirePoint.position, laserFirePoint.position + laserFirePoint.right * defDistanceRay);
        }
    }

    void Draw2DRay(Vector2 startPos, Vector2 endPos)
    {
        m_lineRenderer.SetPosition(0, startPos);
        m_lineRenderer.SetPosition(1, endPos);
    }
}
