using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject target;
    void Start()
    {
        target = GameManager.Instance.player;
        target = Player.instance.gameObject;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
