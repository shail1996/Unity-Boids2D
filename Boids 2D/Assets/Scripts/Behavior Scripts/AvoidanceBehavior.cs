using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Flock/Behavior/Avoidance")]
public class AvoidanceBehavior : FlockBehavior
{
    public override Vector2 CalculateMove(FlockAgent agent, List<Transform> context, Flock flock)
    {
        // no neighbors
        if (context.Count == 0)
        {
            return Vector2.zero;
        }

        //averaging points
        Vector2 avoidanceMove = Vector2.zero;
        int nAvoid = 0;
        foreach (Transform item in context)
        {
            if (Vector2.SqrMagnitude(item.position - agent.transform.position) < flock.SquareAvoidRadius)
            {
                nAvoid++;
                avoidanceMove += (Vector2)(agent.transform.position - item.position);
            }
        }

        if (nAvoid > 0)
        {
            avoidanceMove /= nAvoid;
        }

        return avoidanceMove;
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
