using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PathDefinition : MonoBehaviour {

    public Transform[] Points;

    public IEnumerator<Transform> GetPathEnumerator()
    {
        if (Points == null || Points.Length < 2)
            yield break;

        int direction = 1;
        int index = 0;

        while(true)
        {
            yield return Points[index];

            if(index <= 0)
            {
                direction = 1;
            }
            else if(index >= Points.Length - 1)
            {
                direction = -1;
            }
            index = index + direction;
        }
    }

    public void onDrawGizmos()
    {
        if (Points == null || Points.Length < 2)
            return;

        for (var i=1; i<Points.Length; i++)
        {
            Gizmos.DrawLine(Points[i - 1].position, Points[i].position);
        }
    }
}
