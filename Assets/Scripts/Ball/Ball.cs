using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//��
public class Ball : MonoBehaviour
{
    //�׽�Ʈ�� ���� ������ ����, ���Ŀ� ����� �����Դϴ�.
    private enum StateType { Idle, UpMove, DownMove}
    private StateType stateType = StateType.DownMove;
    //---------------------------------------------------------------------------------------------------------------

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
        rigid2D.velocity = transform.up * 500 * Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //StateType�� �׽�Ʈ�� ���� ��� ���� �뵵�̸� ���Ŀ� ����� �����Դϴ�.
        if (collision.transform.tag.Equals("Paddle") && stateType.Equals(StateType.DownMove))
        {
            stateType = StateType.UpMove;
            // �浹 ����� �е��� ��� ȸ�� ���� ���� �ݴϴ�.
            transform.rotation = Quaternion.Euler(transform.eulerAngles.x, transform.eulerAngles.y, refAngleCalc.getAngle(transform.position.x, collision));
        }
        else if (collision.transform.tag.Equals("Side"))
            // �浹 ����� ������ ��� ȸ�� ���� �ݴ�� �ݴϴ�.
            transform.rotation = Quaternion.Euler(transform.eulerAngles.x, transform.eulerAngles.y, refAngleCalc.getAngle(transform.eulerAngles.z));
        else if ((collision.transform.tag.Equals("Ceiling") || collision.transform.tag.Equals("Brick")) && stateType.Equals(StateType.UpMove))
        {
            stateType = StateType.DownMove;
            // �浹 ����� õ���� ��� ȸ�� ���� ������ �ݴϴ�.
            transform.rotation = Quaternion.Euler(transform.eulerAngles.x, transform.eulerAngles.y, refAngleCalc.getAngle2(transform.eulerAngles.z));
        }
    }
}
