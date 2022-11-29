using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutBounds : MonoBehaviour
{
    public float upperLimit = 20f;
    public float LowerLimit = -10f;

    private void Update()
    {
        if (transform.position.z < LowerLimit)
        {
            Destroy(gameObject);
        }

        if (transform.position.z > upperLimit)
        {
            Destroy(gameObject);
        }
    }
}
