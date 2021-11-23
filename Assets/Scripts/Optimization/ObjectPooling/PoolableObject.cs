using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Ǯ���� ������Ʈ
public class PoolableObject : MonoBehaviour
{
    private Pool pool;

    public void EnQueue()
    {
        pool?.EnQueue(gameObject);
    }

    public Pool Pool { set { pool = value; } }
}
