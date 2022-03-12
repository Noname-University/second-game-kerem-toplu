using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, IKillable
{
    [SerializeField]
    private float health;

    [SerializeField]
    private float speed;

    private void Start()
    {
        LeanTween.moveX(gameObject, transform.position.x + 10, .25f).setOnComplete(
        () =>
        LeanTween.moveX(gameObject, transform.position.x - 20, .5f).setEaseInOutCubic().setLoopPingPong()
        );
    }


    private void Update()
    {
        transform.position -= Vector3.forward * speed * Time.deltaTime;

    }


    public void Kill()
    {
        var random = Random.Range(0, 10);

        if (random == 1)
        {

            CollactableController.Instance.SpawnCollectable(transform.position);

        }
        gameObject.SetActive(false);


    }

    public void TakeHit(float hit)
    {
        health -= hit;
        if (health < 0)
        {
            Kill();
        }
    }

}
