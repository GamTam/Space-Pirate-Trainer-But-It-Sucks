using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if (other.transform.parent.gameObject.tag.Equals("Bullet") || other.transform.parent.gameObject.tag.Equals("BulletEnemy"))
        {
            #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
            #else
                Application.Quit();
            #endif
        }
    }
}
