using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    GameObject player;

    public GameObject Player
    {
        get
        {
            return player;
        }
        set
        {
            player = value;
        }
    }

    InvadersManager invadersManager;

    public InvadersManager InvadersManager
    {
        get
        {
            return invadersManager;
        }
        set
        {
            invadersManager = value;
        }
    }

    int score;
    public int Score
    {
        get
        {
            return score;
        }
        set
        {
            text.text = score.ToString();
            score = value;
        }
    }
    [SerializeField]
    int invaderDirection;
    public int InvaderDirection
    {
        get
        {
            return invaderDirection;
        }
        set
        {
            invaderDirection = value;
        }
    }
    [SerializeField]
    float invaderSpeed;

    public float InvaderSpeed
    {
        get
        {
            return invaderSpeed;
        }
        set
        {
            invaderSpeed = value;
        }
    }

    [SerializeField]
    int minBounds;
    [SerializeField]
    int maxBounds;

    public int MinBounds
    {
        get
        {
            return minBounds;
        }
        set
        {
            minBounds = value;
        }
    }

    public int MaxBounds
    {
        get
        {
            return maxBounds;
        }
        set
        {
            maxBounds = value;
        }
    }

    [SerializeField]
    TextMeshProUGUI text;
    public static GameManager instance;

    private void Awake()
    {
        if (instance == null)
        instance = this;

        invadersManager = GameObject.FindObjectOfType<InvadersManager>();
    }

}
