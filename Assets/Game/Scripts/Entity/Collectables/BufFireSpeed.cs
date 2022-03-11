using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BufFireSpeed : MonoBehaviour, ICollectible
{
    [SerializeField]
    private float speed;
    private void Update()
    {
        transform.position -= transform.forward * Time.deltaTime * speed;
    }
    public void Collect()
    {



    }

    public void Spawn(Vector3 position)
    {
        transform.position = position;
        gameObject.SetActive(true);
    }
}
