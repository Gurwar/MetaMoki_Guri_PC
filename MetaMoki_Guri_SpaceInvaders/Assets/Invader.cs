using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invader : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(1,0,0) * GameManager.instance.InvaderSpeed * GameManager.instance.InvaderDirection * Time.deltaTime;
        if (transform.position.x < GameManager.instance.MinBounds)
        {
            transform.position = new Vector3(GameManager.instance.MinBounds, transform.position.y, transform.position.z);
            GameManager.instance.InvadersManager.MoveInvadersDown();
            GameManager.instance.InvaderDirection = GameManager.instance.InvaderDirection * -1;
        }
        else if (transform.position.x > GameManager.instance.MaxBounds)
        {
            transform.position = new Vector3(GameManager.instance.MaxBounds, transform.position.y, transform.position.z);
            GameManager.instance.InvadersManager.MoveInvadersDown();
            GameManager.instance.InvaderDirection = GameManager.instance.InvaderDirection * -1;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            GameManager.instance.InvadersManager.Invaders.Remove(gameObject);
            GameManager.instance.Score++;
            GameManager.instance.InvaderSpeed += .05f;
            Destroy(gameObject);
            Destroy(collision.gameObject);
            
        }
    }
}
