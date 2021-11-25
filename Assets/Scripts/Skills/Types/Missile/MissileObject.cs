using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// �̻��� �߻�ü ������Ʈ�Դϴ�.
public class MissileObject : MonoBehaviour
{
    // ������Ʈ Ǯ���� ����մϴ�.
    [SerializeField]
    private Pool pool;

    // ����ü �߻� ��ġ�� �迭�� �޽��ϴ�.
    [SerializeField]
    private Transform[] muzzleTs = new Transform[2];

    // ���� ����Դϴ�.
    private GameObject target;

    // ���� ���� �ڷ�ƾ�Դϴ�.
    private IEnumerator shootingAsync;

    private void Awake()
    {
        Destroy(this, 2f);
    }

    private void Start()
    {
        pool?.Init();

        // �е��� ����ٴմϴ�.
        target = GameObject.FindGameObjectWithTag("Paddle");

        shootingAsync = ShootingAsync();
        StartCoroutine(shootingAsync);
    }

    private void Update()
    {
        if(target != null)
            transform.position = target.transform.position;
    }

    // ���� ���� �ڷ�ƾ�Դϴ�.
    private IEnumerator ShootingAsync()
    {
        // �߻� ��ġ�� ���� ����ü�� Ǯ����ŵ�ϴ�.
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
