using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Helpers;
public class CollactableController : MonoSingleton<CollactableController>
{
    [SerializeField]
    private CollectableType[] collectablesTypes;
    private ICollectible[] collectables;

    private int collectableCount;

    private void Awake()
    {
        InitPool();
    }
    private void Start()
    {

    }


    public void SpawnCollectable(Vector3 position)
    {
        var index = Random.Range(0, collectableCount);
        var collectable = collectables[index];
        collectable.Spawn(position);


    }
    private void InitPool()
    {
        for (int i = 0; i < collectablesTypes.Length; i++)
        {
            collectableCount += collectablesTypes[i].Count;

        }
        collectables = new ICollectible[collectableCount];
        int index = 0;
        for (int i = 0; i < collectablesTypes.Length; i++)
        {
            for (int j = 0; j <= collectablesTypes[i].Count; j++)
            {
                var collectable = Instantiate(collectablesTypes[i].Prefab);
                collectable.SetActive(false);
                collectables[i] = collectable.GetComponent<ICollectible>();
                index++;

            }

        }


    }
}

[System.Serializable]
public class CollectableType
{


    public GameObject Prefab;
    public int Count;
    public int SpawnChance;

}
