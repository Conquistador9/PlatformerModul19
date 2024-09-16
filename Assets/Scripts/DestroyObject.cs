using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("FireEnergy"))
        {
            Destroy(gameObject);
        }
    }
}