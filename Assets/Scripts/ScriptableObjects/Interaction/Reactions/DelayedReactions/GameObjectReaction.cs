using System;
using UnityEngine;

public class GameObjectReaction : DelayedReaction
{

    public GameObject CloseObject;
    public bool setActive;

   
    protected override void ImmediateReaction()
    {
        CloseObject.SetActive(setActive);
    }
}