using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//벽돌 생성기
public class BrickGenerator : MonoBehaviour
{
    /// <summary>
    /// 오브젝트 풀을 가져옵니다.
    /// </summary>
    [SerializeField] private Pool pool;

    // 벽돌을 생성을 위한 클래스입니다.
    private BrickFactory brickFactory;

    private void Awake()
    {
        brickFactory = new GeneralBrickFactory();
    }

    private void Start()
    {
        Generate();
    }

    /// <summary>
    /// 벽돌을 생성합니다.
    /// </summary>
    public void Generate()
    {
        // 오브젝트 풀을 초기화 시킵니다.
        pool.poolCount = BrickJson.brickData.brickInfos.Count;
        pool?.Init();

        // 기본 벽돌의 인스턴스를 가져옵니다.
        BrickProduct product = brickFactory.getInstance("BasicBrick");

        // 벽돌을 생성합니다.
        foreach (BrickInfo brickInfo in BrickJson.brickData.brickInfos)
            product.Create(pool, brickInfo.pos);
    }
}
