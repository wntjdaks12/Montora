using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//��
public class Ball : MonoBehaviour
{
    // �� ���¸� �����ɴϴ�.
    private BallState ballState;

    // �ݻ簢 ����� ���� �ҷ��ɴϴ�.
    private ReflectionAngleCalculator refAngleCalc;
   
    private Rigidbody2D rigid2D;

    // �浹 ��ü�� �����ɴϴ�.
    private Collision2D collision;

    private void Awake()
    {
        refAngleCalc = new ReflectionAngleCalculator();

        rigid2D = GetComponent<Rigidbody2D>();

        ballState = BallDownMoveState.GetInstance();
    }

    private void FixedUpdate()
    {
        Move();
    }

    /// <summary>
    /// ���� ���¸� �����մϴ�.
    /// </summary>
    /// <param name="ballState">�� ���� �ν��Ͻ�</param>
    public void setState(BallState ballState)
    {
        this.ballState = ballState;
    }

    /// <summary>
    /// ���� Y�� �������� �̵���ŵ�ϴ�.
    /// </summary>
    private void Move()
    {
        rigid2D.velocity = transform.up * 500 * Time.deltaTime;
    }

    // ���� ������ ���� �ݴϴ�.
    public void DirUp()
    {
        transform.rotation = Quaternion.Euler(transform.eulerAngles.x, transform.eulerAngles.y, refAngleCalc.getAngle(transform.position.x, collision));
    }

    // ���� ������ �ݴ�� �ݴϴ�.
    public void DirRef()
    {
        transform.rotation = Quaternion.Euler(transform.eulerAngles.x, transform.eulerAngles.y, refAngleCalc.getAngle(transform.eulerAngles.z));
    }

    // ���� ������ �Ʒ��� �ݴϴ�.
    public void DirDown()
    {
        // �浹 ����� õ���� ��� ȸ�� ���� ������ �ݴϴ�.
        transform.rotation = Quaternion.Euler(transform.eulerAngles.x, transform.eulerAngles.y, refAngleCalc.getAngle2(transform.eulerAngles.z));
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        this.collision = collision;
            
        if (collision.transform.tag.Equals("Paddle"))
            ballState.UpMove(this);
        else if (collision.transform.tag.Equals("Side"))
            DirRef();
        else if (collision.transform.tag.Equals("Ceiling") || collision.transform.tag.Equals("Brick"))
            ballState.DownMove(this);
    }
}
