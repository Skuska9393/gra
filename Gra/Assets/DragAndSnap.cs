using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;

public class PuzzleSnap : MonoBehaviour
{
    private Vector3 offset;
    private bool isDragging = false;
    private Transform snapTarget = null; // Obiekt docelowy (SnapPoint)

    void Update()
    {
        // Sprawdzenie, czy u¿ytkownik dotyka ekranu
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector3 touchPosition = Camera.main.ScreenToWorldPoint(new Vector3(touch.position.x, touch.position.y, 0));
            touchPosition.z = 0; // Ustawiamy Z na 0, aby dzia³a³o w 2D

            switch (touch.phase)
            {
                case TouchPhase.Began:
                    // Rozpoczêcie przeci¹gania obiektu
                    RaycastHit2D hit = Physics2D.Raycast(touchPosition, Vector2.zero);
                    if (hit.collider != null && hit.collider.gameObject == gameObject)
                    {
                        isDragging = true;
                        offset = gameObject.transform.position - touchPosition;
                    }
                    break;

                case TouchPhase.Moved:
                    // Przesuwanie obiektu
                    if (isDragging)
                    {
                        gameObject.transform.position = touchPosition + offset;
                    }
                    break;

                case TouchPhase.Ended:
                case TouchPhase.Canceled:
                    // Zakoñczenie przeci¹gania i sprawdzenie snapowania
                    isDragging = false;

                    if (snapTarget != null)
                    {
                        // Ustawiamy transform puzzla na transform SnapPoint
                        gameObject.transform.position = snapTarget.position;
                    }

                    snapTarget = null; // Resetowanie snapTarget po zakoñczeniu przeci¹gania
                    break;
            }
        }
    }

    // Funkcja detekcji kolizji
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Sprawdzamy, czy kolidujemy z punktem snapowania (SnapPoint)
        if (collision.CompareTag("SnapPoint"))
        {
            Debug.Log("OnTriggerEnter");
            snapTarget = collision.transform; // Ustawiamy snapTarget jako obiekt kolizji
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        // Resetowanie snapTarget, gdy puzzel opuœci obszar SnapPoint
        if (collision.CompareTag("SnapPoint") && snapTarget == collision.transform)
        {
            Debug.Log("OnTriggerExit");
            snapTarget = null;
        }
    }
}
