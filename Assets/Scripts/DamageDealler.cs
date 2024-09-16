using UnityEngine;

public class DamageDealler : MonoBehaviour
{
    [SerializeField] private float _damage;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            collision.gameObject.GetComponent<Helth>().TakeDamage(_damage);
            Destroy(gameObject);
        }
    }
}