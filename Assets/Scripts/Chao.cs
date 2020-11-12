using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chao : MonoBehaviour
{
    public float diferancaX;

    public float minX;

    private void Update()
    {
        if (transform.position.x <= minX)
        {
            transform.position = new Vector3(
                transform.position.x + diferancaX * 2,
                transform.position.y,
                transform.position.z
            );

        }

    }
}
