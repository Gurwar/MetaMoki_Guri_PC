using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteCountdown : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(WaitUntilDelete());
    }

    IEnumerator WaitUntilDelete()
    {
        yield return new WaitForSeconds(1);
        Destroy(gameObject);
    }
}
