using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallController : MonoBehaviour
{
    public Transform wallPrefab;

    public float speed = 1f;

    public float gapHalfSize = 2.5f;

    Transform topPart, bottomPart;

    void Start()
    {
        topPart = Instantiate(wallPrefab, this.transform);
        topPart.localPosition = new Vector2();
    }

    void LateUpdate()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }
}