using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class FollowPath : MonoBehaviour {

	public enum FollowType
    {
        MoveToward, Lerp
    }

    public FollowType Type = FollowType.MoveToward;
    public PathDefinition Path;
    public float Speed = 1;
    public float MaxDistanceToGoal = .1f;

    private IEnumerator<Transform> currentPoint;

    public void Start()
    {
        currentPoint = Path.GetPathEnumerator();
        currentPoint.MoveNext();

        transform.position = currentPoint.Current.position;
    }

    public void Update()
    {
        if(Type == FollowType.MoveToward)
        {
            transform.position = Vector3.MoveTowards(transform.position, currentPoint.Current.position, Time.deltaTime * Speed);
        }
        else if (Type == FollowType.Lerp)
        {
            transform.position = Vector3.MoveTowards(transform.position, currentPoint.Current.position, Time.deltaTime * Speed);
        }

        var distanceSquared = (transform.position - currentPoint.Current.position).sqrMagnitude;
        if (distanceSquared < MaxDistanceToGoal * MaxDistanceToGoal)
        {
            currentPoint.MoveNext();
        }
    }
}
