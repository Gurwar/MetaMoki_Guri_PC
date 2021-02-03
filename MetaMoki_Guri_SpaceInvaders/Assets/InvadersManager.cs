using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvadersManager : MonoBehaviour
{
    public List<GameObject> Invaders = new List<GameObject>();
    [SerializeField]
    Vector2 grid;
    [SerializeField]
    GameObject invader;

    private void Start()
    {
        SpawnInvaders();
    }

    void SpawnInvaders()
    {
        for (int i = (int)grid.x/-2; i < grid.x/2; i++)
        {
            for (int j = (int)grid.y/-2; j < grid.y/2; j++)
            {
                Vector3 position = new Vector3(i * 0.5f, j * 0.5f, 0);
                GameObject temp = (GameObject)Instantiate(invader, transform);
                temp.transform.localPosition = position;
                Invaders.Add(temp);
            }
        }
    }

    public void MoveInvadersDown()
    {
        foreach (GameObject i in Invaders)
        {
            if (i != null)
            i.transform.localPosition -= new Vector3(0, .5f, 0);
        }
    }
}
