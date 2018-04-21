using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableSpawner : MonoBehaviour {

    [SerializeField]
    private GameObject _prefabToSpawn;

    [Tooltip("Area size from the center of the world to spawn collectables")]
    [SerializeField]
    private Vector2 _spawnArea;

    [Tooltip("Collectable spawn rate")]
    [SerializeField]
    private float _spawnRate = 5f;

    private float _startTime;
    private bool _spawned;

    private void Start()
    {
        _startTime = Time.time;
    }

    private void Update()
    {
        if ((int)_startTime % (int)_spawnRate == 0 && !_spawned)
        {
            GameObject spawnedObject = Instantiate(_prefabToSpawn,
            new Vector3(Random.Range(-_spawnArea.x, _spawnArea.x), 0.5f, Random.Range(-_spawnArea.y, _spawnArea.y)), transform.rotation);
            _spawned = true;
        } else if ((int)_startTime % (int)_spawnRate != 0)
        {
            _spawned = false;
        }
        _startTime += Time.deltaTime;
    }
}


