using System.Collections;
using System.Collections.Generic;
using NaughtyAttributes;
using UnityEngine;
using UnityEngine.InputSystem;

public class GunManager : MonoBehaviour
{
    [SerializeField] private BulletController _bulletPrefab;
    [SerializeField] private Transform _spawnPoint;

    private PlayerInput _inputManager;
    private InputAction _shoot;

    private void Start()
    {
        _inputManager = FindObjectOfType<PlayerInput>();

        _shoot = _inputManager.actions["Activate"];
    }

    private void Update()
    {
        if (_shoot.triggered) Shoot();
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
