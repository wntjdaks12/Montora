using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 벽돌 추상 클래스
/// </summary>
public abstract class Brick : MonoBehaviour
{
    public PoolableObject poolableObject;
    public ParticleSystem ps;

    private GameManager gameManager;

    private void Awake()
    {
        if (GameObject.FindObjectOfType<GameManager>() == null)
            return;

        gameManager = GameObject.FindObjectOfType<GameManager>();
    }

    private void Start()
    {
        gameManager.BrickNum = gameManager.BrickNum + 1;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Ball" || collision.transform.tag == "Projectile")
        {
            if (gameManager != null)
            {
                gameManager.Score = gameManager.Score + 1;
                gameManager.BrickNum = gameManager.BrickNum - 1;
            }

            if (ps != null)
            {
                ps.transform.parent = null;
                ps.Play();
            }

            poolableObject?.EnQueue();
        }
    }
}
