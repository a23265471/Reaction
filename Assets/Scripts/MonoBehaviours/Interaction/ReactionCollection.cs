using UnityEngine;

// This script acts as a collection for all the
// individual Reactions that happen as a result
// of an interaction.
public class ReactionCollection : MonoBehaviour
{
    private Reaction[] reaction;
    private void Awake()
    {
        reaction = GetComponents<Reaction>();
    }
    private void Start()
    {
        for(int i = 0; i < reaction.Length; i++)
        {
            DelayedReaction delaReaction = reaction[i] as DelayedReaction;
            if (delaReaction != null)
            {
                delaReaction.Init();
            }
            else
                reaction[i].Init();
        }

    }

    public void React()
    {
        for (int i = 0; i < reaction.Length; i++)
        {
            DelayedReaction delaReaction = reaction[i] as DelayedReaction;
            if (delaReaction != null)
            {
                delaReaction.React();
            }
            else
                reaction[i].React();
        }


    }
}
