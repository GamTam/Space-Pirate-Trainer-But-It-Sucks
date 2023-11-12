using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnText : MonoBehaviour
{
    [SerializeField] private GameObject scoreText;

    [SerializeField] private Transform spawn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadText()
    {
        Instantiate(scoreText, spawn.position, spawn.rotation);
    }
}
