using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnsMovement : MonoBehaviour
{
    public float speed;
    void FixedUpdate()
    {
        transform.Translate(-speed * Time.fixedDeltaTime, 0, 0);
    }
}
