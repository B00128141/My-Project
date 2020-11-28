using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeftX : MonoBehaviour
{
    public float speed;
    private float leftBound = -10;

    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * speed);

        if (transform.position.x < leftBound && !gameObject.CompareTag  ("background"))
        {
            Destroy(gameObject);
        }
    }
}
