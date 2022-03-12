using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField]
    private EnemyLines[] lines;

    private void Start()
    {
        var ortographic = Camera.main.orthographicSize;
        for (int i = 1; i <= lines.Length; i++)
        {
            for (int j = 0; j < lines[i].count; j++)
            {
                var enemy = Instantiate(lines[i].enemy, new Vector3(
                     -lines[i].count / 2 + lines[i].offset.x * j,
                    0,
                    ortographic + lines[i].offset.y * i



            )

         , Quaternion.identity);

                enemy.transform.eulerAngles = new Vector3(0, 180, 0);
            }

        }
    }
}


[System.Serializable]
public class EnemyLines
{
    [SerializeField]
    public GameObject enemy;
    [SerializeField]
    public int count;
    [SerializeField]
    public Vector2 offset;


}
