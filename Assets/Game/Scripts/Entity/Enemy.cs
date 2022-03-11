using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    private bool active = false;

    private bool jobdone = false;
    private void Update()
    {

        if (active && !jobdone)
        {

            jobdone = true;
            CollactableController.Instance.SpawnCollectable(transform.position);

        }
    }
}
