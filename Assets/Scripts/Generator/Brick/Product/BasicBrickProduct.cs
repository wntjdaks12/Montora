using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// �⺻ ���� ������
/// </summary>
public class BasicBrickProduct : BrickProduct
{
    /// <summary>
    /// ������ �����մϴ�.
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
