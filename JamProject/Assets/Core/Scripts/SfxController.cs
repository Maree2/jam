﻿using UnityEngine;
using System.Collections;

public class SfxController : MonoBehaviour
{
    public Sfx[] elements;

    public void Play(int elementId)
    {
        elements[elementId].Play();
    }

    public void Stop(int elementId)
    {
        elements[elementId].Stop();
    }

    public void Pizzicato(int elementId)
    {
        elements[elementId].Pizzicato();
    }

    public void SetChord(int chordId)
    {
        for (int i = 0; i < elements.Length; i++)
        {
            elements[i].SetChords(chordId);
        }
    }
}
