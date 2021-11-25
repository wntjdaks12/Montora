using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ���� �߻� Ŭ����
/// </summary>
public abstract class Brick : MonoBehaviour
{
    public PoolableObject poolableObject;
    public ParticleSystem ps;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Ball" || collision.transform.tag == "Projectile")
        {
            ps.transform.parent = null;

            ps?.Play();

            poolableObject?.EnQueue();
        }
    }
}
