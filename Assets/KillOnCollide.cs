using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillOnCollide : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        Destroy(transform.parent.gameObject);
    }
}
