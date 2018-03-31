using UnityEngine;

// This script acts as a collection for all the
// individual Reactions that happen as a result
// of an interaction.
public class ReactionCollection : MonoBehaviour
{
    private Reaction[] reactions;
    private void Awake()
    {
        reactions = GetComponents<Reaction>();
    }

    private void Start()
    {
        for (int i = 0; i < reactions.Length; i++)
        {
            DelayedReaction delayReaction = reactions[i] as DelayedReaction;
            if (delayReaction != null)
                delayReaction.Init();
            else
                reactions[i].Init();
        }
    }

    public void React()
    {
        for (int i = 0; i < reactions.Length; i++)
        {
            DelayedReaction delayReaction = reactions[i] as DelayedReaction;
            if (delayReaction != null)
                delayReaction.React();
            else
                reactions[i].React();
        }
    }
}
