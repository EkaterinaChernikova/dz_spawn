using System.Collections;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    [SerializeField] private float _delay = 2.0f;
    [SerializeField] private Movement _enemy;

    private Spawner[] _points;

    private WaitForSeconds _timer;

    private void Start()
    {
        _points = GetComponentsInChildren<Spawner>();
        _timer = new WaitForSeconds(_delay);
        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        while (true)
        {
            _points[Random.Range(0, _points.Length)].SpawnEnemy();
            yield return _timer;
        }
    }
}
