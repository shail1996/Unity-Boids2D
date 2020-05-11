using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Flock/Behavior/Alignment")]
public class AlignmentBehavior : FlockBehavior
{
    public override Vector2 CalculateMove(FlockAgent agent, List<Transform> context, Flock flock)
    {
        // no neighbors
        if (context.Count == 0)
        {
            return agent.transform.up;
        }

        //averaging points
        Vector2 alignmentMove = Vector2.zero;
        foreach (Transform item in context)
        {
            alignmentMove += (Vector2)item.transform.up;
        }
        alignmentMove /= context.Count;

        return alignmentMove;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
