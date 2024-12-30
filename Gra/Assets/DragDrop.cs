using UnityEngine;

public class DragDrop : MonoBehaviour
{
    private Vector3 startPosition; // Początkowa pozycja
    private bool isDragging = false;

    public string correctBinTag; // Tag poprawnego pojemnika

    private void OnMouseDown()
    {
        startPosition = transform.position;
        isDragging = true;
    }

private void OnMouseDrag()
{
    Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    transform.position = new Vector3(mousePosition.x, mousePosition.y, transform.position.z);
}

    private void OnMouseUp()
    {
        isDragging = false;

        // Sprawdzenie, czy śmieć jest w pojemniku
        Collider2D[] colliders = Physics2D.OverlapPointAll(transform.position);
        bool placedCorrectly = false;

        foreach (var collider in colliders)
        {
            if (collider.CompareTag(correctBinTag)) // Jeśli trafiono w odpowiedni pojemnik
            {
                placedCorrectly = true;
                Destroy(gameObject); // Usunięcie śmiecia
                break;
            }
        }

        if (!placedCorrectly)
        {
            // Jeśli śmieć wylądował w złym miejscu
            transform.position = startPosition; // Powrót na pozycję startową
        }
    }
}