using UnityEngine;

public class FireEnergy : MonoBehaviour
{
    private void Start()
    {
        Destroy(gameObject, 0.3f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Box"))
        {
            Destroy(gameObject);
        }
    }
}