using UnityEngine;

public class DamageDealler : MonoBehaviour
{
    [Header("Setting")]
    [SerializeField] private float _damage = 25f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            collision.gameObject.GetComponent<EnemyHelth>().TakeDamage(_damage);
            Destroy(gameObject);
        }
    }
}