using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 기본 벽돌 생산자
/// </summary>
public class BasicBrickProduct : BrickProduct
{
    /// <summary>
    /// 벽돌을 생성합니다.
    /// </summary>
    /// <param name="pool">오브젝트 풀</param>
    /// <param name="pos">생성 위치</param>
    public override void Create(Pool pool, Vector3 pos)
    {
        if (pool == null)
            return;

        pool.DeQueue().transform.position = pos;
    }
}
