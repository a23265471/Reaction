﻿using System;
using UnityEngine;

// This Reaction is for turning Behaviours on and
// off.  Behaviours are a subset of Components
// which have the enabled property, for example
// all MonoBehaviours are Behaviours as well as
// Animators, AudioSources and many more.
public class BehaviourReaction : DelayedReaction
{
    public Behaviour behavior;
    public bool enabledState;
    protected override void ImmediateReaction()
    {
        behavior.enabled = enabledState;
    }
}