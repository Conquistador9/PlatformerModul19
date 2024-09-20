using UnityEngine;

public class Destroy : MonoBehaviour
{
    [Header("Components")]
    [SerializeField] private CoinText _coinText;
    [SerializeField] private CoinParticle _coinParticle;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            _coinText.AddCoin();
            _coinParticle.ParticleOn();
            GetComponent<SpriteRenderer>().enabled = false;
            GetComponent<Collider2D>().enabled = false;
            Destroy(gameObject, 0.5f);
        }
    }
}