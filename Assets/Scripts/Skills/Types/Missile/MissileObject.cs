using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 미사일 발사체 오브젝트입니다.
public class MissileObject : MonoBehaviour
{
    // 오브젝트 풀링을 사용합니다.
    [SerializeField]
    private Pool pool;

    // 투사체 발사 위치를 배열로 받습니다.
    [SerializeField]
    private Transform[] muzzleTs = new Transform[2];

    // 추적 대상입니다.
    private GameObject target;

    // 슈팅 관련 코루틴입니다.
    private IEnumerator shootingAsync;

    private void Awake()
    {
        Destroy(this, 2f);
    }

    private void Start()
    {
        pool?.Init();

        // 패들을 따라다닙니다.
        target = GameObject.FindGameObjectWithTag("Paddle");

        shootingAsync = ShootingAsync();
        StartCoroutine(shootingAsync);
    }

    private void Update()
    {
        if(target != null)
            transform.position = target.transform.position;
    }

    // 슈팅 관련 코루틴입니다.
    private IEnumerator ShootingAsync()
    {
        // 발사 위치에 따라 투사체를 풀링시킵니다.
        while (true)
        {
            for (int i = 0; i < 2; i++)
            {
                if (pool == null || pool.ObjectPool.Count == 0)
                {
                    StopCoroutine(shootingAsync);

                    break;
                }
                var obj1 = pool.DeQueue();

                obj1.transform.position = muzzleTs[i].position;
            }

            yield return new WaitForSeconds(0.2f);
        }
    }
}
