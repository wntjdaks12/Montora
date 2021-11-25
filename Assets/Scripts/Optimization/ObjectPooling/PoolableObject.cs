using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//풀링할 오브젝트
public class PoolableObject : MonoBehaviour
{
    private Pool pool;

    public void EnQueue()
    {
        if (pool != null)
            pool.EnQueue(gameObject);
        else
            Destory();
    }

    private void Destory()
    {
        Destroy(this.gameObject);
    }

    public Pool Pool { set { pool = value; } }
}
