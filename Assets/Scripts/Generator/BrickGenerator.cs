using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickGenerator : MonoBehaviour
{
    /// <summary>
    /// 오브젝트 풀을 가져옵니다.
    /// </summary>
    [SerializeField] private Pool pool;

    private void Start()
    {
        // 오브젝트 풀을 초기화 시킵니다.
        pool.poolCount = BrickJson.brickData.brickInfos.Count;
        pool?.Init();

        foreach (BrickInfo brickInfo in BrickJson.brickData.brickInfos)
            Create(brickInfo.pos);
    }

    // 오브젝트를 생성합니다.
    private void Create(Vector3 pos)
    {
        if (pool == null)
            return;

        pool.DeQueue().transform.position = pos;
    }
}
