using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//공
public class Ball : MonoBehaviour
{
    // 반사각 계산을 위해 불러옵니다.
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
    /// 백터 Y를 기준으로 이동시킵니다.
    /// </summary>
    private void Move()
    {
        rigid2D.velocity = Vector2.up * 20 * Time.deltaTime;
        transform.Translate(Vector2.up * Time.deltaTime * 15);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag.Equals("Paddle"))
            // 충돌 대상이 패들일 경우 회전 값을 위로 줍니다.
            transform.rotation = Quaternion.Euler(transform.eulerAngles.x, transform.eulerAngles.y, refAngleCalc.getAngle(transform.position.x, collision));
        else if (collision.transform.tag.Equals("Side"))
            // 충돌 대상이 측면일 경우 회전 값을 반대로 줍니다.
            transform.rotation = Quaternion.Euler(transform.eulerAngles.x, transform.eulerAngles.y, refAngleCalc.getAngle(transform.eulerAngles.z));
        else if (collision.transform.tag.Equals("Ceiling"))
            // 충돌 대상이 천장일 경우 회전 값을 밑으로 줍니다.
            transform.rotation = Quaternion.Euler(transform.eulerAngles.x, transform.eulerAngles.y, refAngleCalc.getAngle2(transform.eulerAngles.z));
    }
}
