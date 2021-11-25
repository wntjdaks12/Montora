using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//����ü Ŭ�����Դϴ�.
public class Projectile : MonoBehaviour
{
    private Rigidbody2D rigid2D;

    // ������Ʈ Ǯ���� ����մϴ�.
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
    /// ����ü�� �̵���ŵ�ϴ�.
    /// </summary>
    /// <param name="dir">�ش� ����</param>
    /// <param name="spd">�̵� �ӵ�</param>
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
