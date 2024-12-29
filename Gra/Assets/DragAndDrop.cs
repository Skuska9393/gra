using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    private Vector3 startPosition; // Pozycja początkowa śmiecia
    private bool isDragging = false;

    void Start()
    {
        startPosition = transform.position; // Zapamiętanie pozycji początkowej
    }

    void OnMouseDown()
    {
        isDragging = true; // Rozpoczęcie przeciągania
    }

    void OnMouseDrag()
    {
        if (isDragging)
        {
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePosition.z = 0; // Zablokowanie osi Z (dla kamery 2D)
            transform.position = mousePosition; // Przesunięcie obiektu
        }
    }

    void OnMouseUp()
    {
        isDragging = false; // Zatrzymanie przeciągania
    }

    public void ResetPosition()
    {
        transform.position = startPosition; // Powrót do pozycji początkowej
    }
}