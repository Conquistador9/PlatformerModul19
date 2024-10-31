using UnityEngine;

public class Teleport : MonoBehaviour
{
    [SerializeField] private Transform _point;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.transform.position = _point.transform.position;
        }
    }
}