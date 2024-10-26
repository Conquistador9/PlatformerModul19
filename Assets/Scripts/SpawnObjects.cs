using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour
{
    [SerializeField] private List<GameObject> _objects = new(3);
    [SerializeField] private Transform _spawnPoint;

    private void Start()
    {
        StartCoroutine(SpawnObjectsDelay());
    }

    private IEnumerator SpawnObjectsDelay()
    {
        while (true)
        {
            if (_objects.Count > 0)
            {
                int randomIndex = Random.Range(0, _objects.Count);
                GameObject obj = _objects[randomIndex];

                if (obj != null)
                {
                    Instantiate(obj, _spawnPoint.position, Quaternion.identity);
                }
            }
            yield return new WaitForSeconds(4f);
        }
    }
}