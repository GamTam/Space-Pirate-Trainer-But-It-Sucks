using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationEffectTriggers : MonoBehaviour
{
    private SoundManager _soundManager;
    
    public void PlaySound(string sound)
    {
        Globals.SoundManager.Play(sound);
    }
}
