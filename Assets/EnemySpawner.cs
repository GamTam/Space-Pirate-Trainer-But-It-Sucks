using System.Collections;
using System.Collections.Generic;
using NaughtyAttributes;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private float _radius;
    [SerializeField] [MinMaxSlider(0, 10f)] private Vector2 _spawnFrequency;
    [FormerlySerializedAs("_enemy")] [SerializeField] GameObject[] _enemies;
    [SerializeField] TMP_Text _scoreText;

    private float _spawnTimer;

    private void Start()
    {
        _spawnTimer = Random.Range(_spawnFrequency.x, _spawnFrequency.y);
        FindObjectOfType<MusicManager>().Play("battle");
    }
    

    private void Update()
    {
        _scoreText.text = $"Score: {Globals.score}";
        _spawnTimer -= Time.deltaTime;

        if (_spawnTimer <= 0)
        {
            _spawnTimer = Random.Range(_spawnFrequency.x, _spawnFrequency.y);
            SpawnEnemy();
        }
    }
    
    [Button()]
    public void SpawnEnemy()
    {
        GameObject obj = Instantiate(_enemies[Random.Range(0, _enemies.Length)]);
        do
        {
            obj.transform.position = Random.onUnitSphere * Random.Range(_radius * 0.75f, _radius * 1.5f);
        } while (obj.transform.position.y <= 0f);

        obj.SetActive(true);
    }

    // Vector3 RandomCircle ( Vector3 center ,   float radius  ){
    //     float ang = Random.value * 360;
    //     Vector3 pos;
    //     pos.x = center.x + radius * Mathf.Sin(ang * Mathf.Deg2Rad);
    //     pos.y = center.y + radius * Mathf.Cos(ang * Mathf.Deg2Rad);
    //     pos.z = center.z + radius * Mathf.Cos(ang * Mathf.Deg2Rad);
    //     return pos;
    // }
}
