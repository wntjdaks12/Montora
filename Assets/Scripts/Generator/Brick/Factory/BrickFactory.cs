using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ���� ���� �ν��Ͻ� ����
/// </summary>
public abstract class BrickFactory
{
    public abstract BrickProduct getInstance(string name);
}
