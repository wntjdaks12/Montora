using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickGenerator : MonoBehaviour
{
    /// <summary>
    /// ������Ʈ Ǯ�� �����ɴϴ�.
    /// </summary>
    [SerializeField] private Pool pool;

    private void Start()
    {
        // ������Ʈ Ǯ�� �ʱ�ȭ ��ŵ�ϴ�.
        pool.poolCount = BrickJson.brickData.brickInfos.Count;
        pool?.Init();

        foreach (BrickInfo brickInfo in BrickJson.brickData.brickInfos)
            Create(brickInfo.pos);
    }

    // ������Ʈ�� �����մϴ�.
    private void Create(Vector3 pos)
    {
        if (pool == null)
            return;

        pool.DeQueue().transform.position = pos;
    }
}
