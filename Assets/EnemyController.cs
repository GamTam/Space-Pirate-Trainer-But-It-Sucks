using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnemyController : MonoBehaviour
{
    [SerializeField] private GameObject _explosion;
    [SerializeField] private GameObject _scoreObj;
    [SerializeField] private Transform _player;
    [SerializeField] private float _speed;
    [SerializeField] private float _score;
    [SerializeField] private bool _lookAtPlayer;
    private SphereCollider _col;

    private void Start()
    {
        _speed *= Random.Range(-2f, 2f);
    }

    private void Update()
    {
        if (!_lookAtPlayer) return;
        
        transform.RotateAround(_player.position, new Vector3(0, 1, 0), _speed * Time.deltaTime);
        
        transform.LookAt(_player);
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.parent.gameObject.tag.Equals("Bullet"))
        {
            GameObject obj = Instantiate(_explosion);
            obj.transform.position = transform.position;
            obj.transform.rotation = transform.rotation;

            obj = Instantiate(_scoreObj);

            int score = (int) Random.Range(_score * 0.5f, _score * 1.5f);
            Globals.score += score;
            
            obj.GetComponent<TextLife>().Text.text = $"+{score}";
            obj.transform.position = transform.position;
            obj.transform.rotation = transform.rotation;
            
            Destroy(gameObject);
            Destroy(collision.transform.parent.gameObject);
        }
    }
}
