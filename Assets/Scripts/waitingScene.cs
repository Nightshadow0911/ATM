using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waitingScene : MonoBehaviour
{
    //대기화면에서 점이 움직이는 모션
    public float moveSpeed = 0.5f;
    private Vector3 destination;
    private Vector3 initialPosition;
    private int currentPoint = 0;

    private Vector3[] points = new Vector3[]
    {
        new Vector3(0, 0, 0),
        new Vector3(1, 0, 0),
        new Vector3(2, 0, 0),
        new Vector3(3, 0, 0),
        new Vector3(4, 0, 0),
        new Vector3(5, 0, 0),
        new Vector3(6, 0, 0),
        new Vector3(0, 0, 0)
    };

    void Start()
    {
        initialPosition = transform.position;
        destination = initialPosition + points[currentPoint];
        StartCoroutine(MoveToNewDestination());
    }

    IEnumerator MoveToNewDestination()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.5f);

            currentPoint = (currentPoint + 1) % points.Length;

            destination = initialPosition + points[currentPoint];
            transform.position = destination;
        }
    }
}