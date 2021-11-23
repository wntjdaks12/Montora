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
    /// <param name="pool"></param>
    /// <param name="pos"></param>
    public override void Create(Pool pool, Vector3 pos)
    {
        if (pool == null)
            return;

        pool.DeQueue().transform.position = pos;
    }
}
