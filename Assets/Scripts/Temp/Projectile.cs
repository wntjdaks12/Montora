using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//투사체 클래스입니다.
public class Projectile : MonoBehaviour
{
    private Rigidbody2D rigid2D;

    // 오브젝트 풀링을 사용합니다.
    [SerializeField]
    private PoolableObject poolableObject;

    private void Awake()
    {
        if (GetComponent<Rigidbody2D>() != null)
            rigid2D = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        Move(transform.up, 500);
    }

    /// <summary>
    /// 투사체를 이동시킵니다.
    /// </summary>
    /// <param name="dir">해당 방향</param>
    /// <param name="spd">이동 속도</param>
    public void Move(Vector3 dir, float spd)
    {
        if (rigid2D == null)
            return;

        rigid2D.velocity = dir * spd * Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Brick" || collision.transform.tag == "Ceiling")
            poolableObject?.EnQueue();
    }
}
