using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject _prefab;

    [SerializeField] private List<Vector3> position;
    [SerializeField] private List<float> timesBetweenSpawn;

    private float _spawnTime;
    private float _time;
    void Start()
    {
        _spawnTime = timesBetweenSpawn[GameManager.DifficultyLevel];
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > _time)
        {
            Spawn();
            _time = Time.time + _spawnTime;
        }
    }
    private void Spawn()
    {
        int p = Random.Range((int)0, (int)4);
        Instantiate(_prefab, position[p], new Quaternion(0, 0, 0, 0));
    }
}
