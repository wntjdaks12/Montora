using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//���� ������
public class BrickGenerator : MonoBehaviour
{
    /// <summary>
    /// ������Ʈ Ǯ�� �����ɴϴ�.
    /// </summary>
    [SerializeField] private Pool pool;

    // ������ ������ ���� Ŭ�����Դϴ�.
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
    /// ������ �����մϴ�.
    /// </summary>
    public void Generate()
    {
        // ������Ʈ Ǯ�� �ʱ�ȭ ��ŵ�ϴ�.
        pool.poolCount = BrickJson.brickData.brickInfos.Count;
        pool?.Init();

        // �⺻ ������ �ν��Ͻ��� �����ɴϴ�.
        BrickProduct product = brickFactory.getInstance("BasicBrick");

        // ������ �����մϴ�.
        foreach (BrickInfo brickInfo in BrickJson.brickData.brickInfos)
            product.Create(pool, brickInfo.pos);
    }
}
