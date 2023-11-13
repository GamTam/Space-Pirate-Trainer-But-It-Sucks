using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _deathTime;

    private float _deathTimer = 0;
    
    void Update()
    {
        transform.position += transform.forward * (_speed * Time.deltaTime);

        _deathTimer += Time.deltaTime;
        if (_deathTimer >= _deathTime) Destroy(gameObject);
    }
}
