using UnityEngine;

public class ParallacsController : MonoBehaviour
{
    [SerializeField] private Transform[] _layers;
    [SerializeField] private float[] _coeff;
    private int _layersCount;

    private void Start()
    {
        _layersCount = _layers.Length;
    }

    private void Update()
    {
        for (int i = 0; i < _layersCount; i++)
        {
            _layers[i].position = transform.position * _coeff[i];
        }
    }
}