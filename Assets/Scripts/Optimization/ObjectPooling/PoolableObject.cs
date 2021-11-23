using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//풀링할 오브젝트
public class PoolableObject : MonoBehaviour
{
    private Pool pool;

    public void EnQueue()
    {
        pool?.EnQueue(gameObject);
    }

    public Pool Pool { set { pool = value; } }
}
