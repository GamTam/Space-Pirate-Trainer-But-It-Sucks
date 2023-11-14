using System.Collections;
using System.Collections.Generic;
using NaughtyAttributes;
using UnityEngine;
using UnityEngine.InputSystem;

public class GunManager : MonoBehaviour
{
    [SerializeField] private BulletController _bulletPrefab;
    [SerializeField] private Transform _spawnPoint;
    [SerializeField] private float _fireSpeed = 0.1f;

    private float _fireTimer;
    [SerializeField] private PlayerInput _inputManager;
    private InputAction _shoot;
    private InputAction _shootHeld;

    private void Start()
    {
        _shoot = _inputManager.actions["Activate"];
        _shootHeld = _inputManager.actions["Activate Value"];
    }

    private void Update()
    {
        if (_shootHeld.ReadValue<float>() > 0.5f || _shoot.triggered)
        {
            _fireTimer += Time.deltaTime;

            if (_fireTimer >= _fireSpeed || _shoot.triggered)
            {
                _fireTimer = 0f;
                Shoot();
            }
        }
    }

    [Button()]
    private void Shoot()
    {
        GameObject bullet = Instantiate(_bulletPrefab.gameObject);

        bullet.SetActive(true);
        bullet.transform.position = _spawnPoint.position;
        bullet.transform.rotation = _spawnPoint.rotation;
    }
}
