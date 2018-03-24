﻿using System;
using UnityEngine;

public class PickedUpItemReaction : DelayedReaction
{
    public Item item;
    private Inventory inventory;



    protected override void SpecificInit()
    {
        inventory = GameObject.FindObjectOfType<Inventory>();
    }
    protected override void ImmediateReaction()
    {
        inventory.AddItem(item);
    }
}