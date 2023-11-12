using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDestroy : MonoBehaviour
{
    [SerializeField] private GameObject boom;

    [SerializeField] private Transform spawn;

    public void LoadBoom()
    {
        Instantiate(boom, spawn.position, spawn.rotation);
    }
}
