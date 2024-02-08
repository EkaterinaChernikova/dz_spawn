using System.Collections;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    [SerializeField] private float _delay = 2.0f;
    [SerializeField] private Movement _enemy;

    private Spawner[] _points;

    private float _timer;

    private void Start()
    {
        _points = GetComponentsInChildren<Spawner>();
    }

    private void Update()
    {
        _timer += Time.deltaTime;

        if (_timer >= _delay)
        {
            _timer = 0;
            _points[Random.Range(0, _points.Length)].SpawnEnemy();
        }
    }
}
