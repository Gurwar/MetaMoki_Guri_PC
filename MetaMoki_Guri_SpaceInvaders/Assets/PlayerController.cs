using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    Transform BulletSpawnTransform;
    [SerializeField]
    float fireRate;
    [SerializeField]
    float movementSpeed;
    [SerializeField]
    GameObject bulletPrefab;
    bool delayFire;
    int fireWaitTime;

    // Update is called once per frame
    void Update()
    {
        Movement();
        Shooting();
    }

    void Shooting()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            if (!delayFire)
            {
                delayFire = true;
                StartCoroutine(firedelayer());
                //fire animation etc.
            }
        }
    }

    IEnumerator firedelayer()
    {
        yield return new WaitForSeconds(fireRate);
        GameObject.Instantiate(bulletPrefab, BulletSpawnTransform.transform.position, BulletSpawnTransform.transform.rotation);
        delayFire = false;
    }

    void Movement()
    {
        int direction = 0;

        if (Input.GetKey(KeyCode.A))
        {
            direction = -1;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            direction = 1;
        }

        if (transform.position.x < GameManager.instance.MinBounds)
        {
            transform.position = new Vector3(GameManager.instance.MinBounds, transform.position.y, transform.position.z);
        }
        else if (transform.position.x > GameManager.instance.MaxBounds)
        {
            transform.position = new Vector3(GameManager.instance.MaxBounds, transform.position.y, transform.position.z);
        }

        transform.position += new Vector3(1, 0, 0) * direction * movementSpeed * Time.deltaTime;
    }
}
