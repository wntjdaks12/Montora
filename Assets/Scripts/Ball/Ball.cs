using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//��
public class Ball : MonoBehaviour
{
    // �� ���¸� �����ɴϴ�.
    private BallState ballState;

    private SkillBehaviour skillBehaviour;

    // �ݻ簢 ����� ���� �ҷ��ɴϴ�.
    private ReflectionAngleCalculator refAngleCalc;
   
    private Rigidbody2D rigid2D;

    // �浹 ��ü�� �����ɴϴ�.
    private Collision2D collision;

    //�ӽ� ������ �ҽ��Դϴ�. �׽�Ʈ��
    public bool isPiercing;

    //���� �Ŵ����� �����մϴ�.
    private GameManager gameManager;

    private void OnEnable()
    {
        SkillButton.skillBehaviourEvent += setSkillBehavaiour;
    }

    private void Awake()
    {
        refAngleCalc = new ReflectionAngleCalculator();

        rigid2D = GetComponent<Rigidbody2D>();

        ballState = BallDownMoveState.GetInstance();

        gameManager = GameObject.FindObjectOfType<GameManager>();
    }

    private void Start()
    {
        gameManager.BallNum = gameManager.BallNum + 1;
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

    public void setSkillBehavaiour(SkillBehaviour skillBehaviour)
    {
        this.skillBehaviour = skillBehaviour;

        UseSkill();
    }

    public void UseSkill()
    {
        skillBehaviour?.Use(gameObject);
    }

    /// <summary>
    /// ���� Y�� �������� �̵���ŵ�ϴ�.
    /// </summary>
    private void Move()
    {
        if (rigid2D == null)
            return;

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

    /*private void OnCollisionEnter2D(Collision2D collision)
    {
        if (ballState == null)
            return;

        this.collision = collision;
            
        if (collision.transform.tag.Equals("Paddle"))
            ballState.UpMove(this);
        else if (collision.transform.tag.Equals("Side"))
            DirRef();
        else if (collision.transform.tag.Equals("Ceiling") || collision.transform.tag.Equals("Brick"))
            ballState.DownMove(this);
    }*/

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (ballState == null)
            return;

        this.collision = collision;

        if (collision.transform.tag.Equals("Paddle"))
            ballState.UpMove(this);
        else if (collision.transform.tag.Equals("Side"))
            DirRef();
        else if (collision.transform.tag.Equals("Ceiling"))
            ballState.DownMove(this);
        else if (collision.transform.tag.Equals("Brick") && !isPiercing)
            ballState.DownMove(this);
        else if (collision.transform.tag.Equals("Floor"))
        {
            gameManager.BallNum = gameManager.BallNum - 1;

            Destroy(this.gameManager);
        }
            
    }

    private void OnDisable()
    {
        SkillButton.skillBehaviourEvent -= setSkillBehavaiour;
    }
}
