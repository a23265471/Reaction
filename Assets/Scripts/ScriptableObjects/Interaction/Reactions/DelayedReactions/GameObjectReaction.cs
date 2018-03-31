using System;
using UnityEngine;

public class GameObjectReaction : DelayedReaction
{
    public GameObject go;
    public bool activeState;
    protected override void ImmediateReaction()
    {
        go.SetActive(activeState);
    }
}