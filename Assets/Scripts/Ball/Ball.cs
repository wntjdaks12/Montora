using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//공
public class Ball : MonoBehaviour
{
    // 공 상태를 가져옵니다.
    private BallState ballState;

    private SkillBehaviour skillBehaviour;

    // 반사각 계산을 위해 불러옵니다.
    private ReflectionAngleCalculator refAngleCalc;
   
    private Rigidbody2D rigid2D;

    // 충돌 물체를 가져옵니다.
    private Collision2D collision;

    //임시 데이터 소스입니다. 테스트용
    public bool isPiercing;

    //게임 매니저를 참조합니다.
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
    /// 공의 상태를 변경합니다.
    /// </summary>
    /// <param name="ballState">공 상태 인스턴스</param>
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
    /// 백터 Y를 기준으로 이동시킵니다.
    /// </summary>
    private void Move()
    {
        if (rigid2D == null)
            return;

        rigid2D.velocity = transform.up * 500 * Time.deltaTime;
    }

    // 진행 방향을 위로 줍니다.
    public void DirUp()
    {
        transform.rotation = Quaternion.Euler(transform.eulerAngles.x, transform.eulerAngles.y, refAngleCalc.getAngle(transform.position.x, collision));
    }

    // 진행 방향을 반대로 줍니다.
    public void DirRef()
    {
        transform.rotation = Quaternion.Euler(transform.eulerAngles.x, transform.eulerAngles.y, refAngleCalc.getAngle(transform.eulerAngles.z));
    }

    // 진행 방향을 아래로 줍니다.
    public void DirDown()
    {
        // 충돌 대상이 천장일 경우 회전 값을 밑으로 줍니다.
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
