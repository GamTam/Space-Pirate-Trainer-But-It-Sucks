using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnText : MonoBehaviour
{
    [SerializeField] private GameObject scoreText;

    [SerializeField] private Transform spawn;

    public void LoadText()
    {
        Instantiate(scoreText, spawn.position, spawn.rotation);
    }
}
