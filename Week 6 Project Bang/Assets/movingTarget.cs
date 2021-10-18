using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingTarget : MonoBehaviour
{
    [SerializeField]
    Transform[] targetPoints;
    int targetIndex = 0;
    Transform currenTargetPoint;

    [SerializeField]
    float speed;

    [SerializeField]
    float dist;

    // Start is called before the first frame update
    void Start()
    {
        UpdateTargetPoint();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, currenTargetPoint.position, speed * Time.deltaTime);

        if (Vector3.Distance(transform.position, currenTargetPoint.position) < dist)
        {
            targetIndex++;

            if (targetIndex >= targetPoints.Length)
                targetIndex = 0;

            UpdateTargetPoint();
        }
    }

    void UpdateTargetPoint()
    {
        currenTargetPoint = targetPoints[targetIndex];
    }
}

