using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 벽돌 생산자
/// </summary>
public abstract class BrickProduct
{
    public abstract void Create(Pool pool, Vector3 pos);
}
