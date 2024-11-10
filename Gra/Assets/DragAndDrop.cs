using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    private Vector3 offset;
    private bool isDragging = false;

    void Update()
    {
        // Sprawdzamy, czy u¿ytkownik dotyka ekranu
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector3 touchPosition = Camera.main.ScreenToWorldPoint(new Vector3(touch.position.x, touch.position.y, 0));

            // Obs³uga ró¿nych faz dotyku
            switch (touch.phase)
            {
                case TouchPhase.Began:
                    // Pocz¹tek dotyku, sprawdzamy czy dotknêliœmy obiekt
                    RaycastHit2D hit = Physics2D.Raycast(touchPosition, Vector2.zero);

                    if (hit.collider != null && hit.collider.gameObject == gameObject)
                    {
                        isDragging = true;
                        offset = gameObject.transform.position - touchPosition;
                    }
                    break;

                case TouchPhase.Moved:
                    // Przesuwanie palcem po ekranie
                    if (isDragging)
                    {
                        gameObject.transform.position = new Vector3(touchPosition.x + offset.x, touchPosition.y + offset.y, 0);
                    }
                    break;

                case TouchPhase.Ended:
                case TouchPhase.Canceled:
                    // Zakoñczenie dotyku
                    isDragging = false;
                    break;
            }
        }
    }
}
