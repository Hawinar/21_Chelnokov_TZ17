using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldController : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Border")
        {
            Destroy(this.gameObject);
            GameManager.HP--;
        }
        if(collision.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
            GameManager.Score += Random.Range((int)50, (int)100);
            Debug.Log(GameManager.Score);
        }
    }
}
