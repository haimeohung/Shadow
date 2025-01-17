﻿using UnityEngine.Audio;
using UnityEngine;

public class Sound : ScriptableObject
{
    new public string name;
    public AudioClip clip;
    [Range(0f, 1f)] public float volume;
    [Range(0.1f, 3f)] public float pitch;
    public bool loop;
}
