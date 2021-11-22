using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//��
public class Ball : MonoBehaviour
{
    // �ݻ簢 ����� ���� �ҷ��ɴϴ�.
    private ReflectionAngleCalculator refAngleCalc;

    private Rigidbody2D rigid2D;

    private void Awake()
    {
        refAngleCalc = new ReflectionAngleCalculator();

        rigid2D = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        Move();
    }

    /// <summary>
    /// ���� Y�� �������� �̵���ŵ�ϴ�.
    /// </summary>
    private void Move()
    {
        rigid2D.velocity = Vector2.up * 20 * Time.deltaTime;
        transform.Translate(Vector2.up * Time.deltaTime * 15);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag.Equals("Paddle"))
            // �浹 ����� �е��� ��� ȸ�� ���� ���� �ݴϴ�.
            transform.rotation = Quaternion.Euler(transform.eulerAngles.x, transform.eulerAngles.y, refAngleCalc.getAngle(transform.position.x, collision));
        else if (collision.transform.tag.Equals("Side"))
            // �浹 ����� ������ ��� ȸ�� ���� �ݴ�� �ݴϴ�.
            transform.rotation = Quaternion.Euler(transform.eulerAngles.x, transform.eulerAngles.y, refAngleCalc.getAngle(transform.eulerAngles.z));
        else if (collision.transform.tag.Equals("Ceiling"))
            // �浹 ����� õ���� ��� ȸ�� ���� ������ �ݴϴ�.
            transform.rotation = Quaternion.Euler(transform.eulerAngles.x, transform.eulerAngles.y, refAngleCalc.getAngle2(transform.eulerAngles.z));
    }
}
