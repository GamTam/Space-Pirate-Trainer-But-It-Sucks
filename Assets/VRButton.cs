using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VRButton : Button
{
    [SerializeField] private float _coolDownTime = 0.5f;
    
    private BoxCollider _collider;
    private float _coolDownTimer;

    void Start()
    {
        _collider = GetComponent<BoxCollider>();
    }

    private void Update()
    {
        _coolDownTimer -= Time.deltaTime;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.parent.gameObject.CompareTag("Bullet") && _coolDownTimer <= 0)
        {
            _coolDownTimer = _coolDownTime;
            Destroy(collision.transform.parent.gameObject);
            onClick.Invoke();
        }
    }
}
