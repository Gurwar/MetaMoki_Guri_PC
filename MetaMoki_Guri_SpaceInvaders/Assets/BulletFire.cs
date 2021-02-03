using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletFire : MonoBehaviour
{
    [SerializeField]
    float Speed;

    private void Update()
    {
        transform.position += new Vector3(0, Speed, 0) * Time.deltaTime;
    }
}
