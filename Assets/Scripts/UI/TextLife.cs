using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextLife : MonoBehaviour
{
    public float life = 1;
    public TMP_Text Text;

    private void Awake()
    {
        Destroy(gameObject, life);
    }
}
