using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextLife : MonoBehaviour
{
    public float life = 1;

    private void Awake()
    {
        Destroy(gameObject, life);
    }
}
