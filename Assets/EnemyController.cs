using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private SphereCollider _col;

    private void Start()
    {
        _col = GetComponent<SphereCollider>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.parent.gameObject.tag.Equals("Bullet"))
        {
            Destroy(gameObject);
            Destroy(collision.transform.parent.gameObject);
        }
    }
}
