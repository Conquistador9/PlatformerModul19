using UnityEngine;

public class CoinParticle : MonoBehaviour
{
    private ParticleSystem _pS;

    private void Awake()
    {
        _pS = GetComponent<ParticleSystem>();
        _pS.Stop();
    }

    public void ParticleOn() => _pS.Play();
}