using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileMoveController : MonoBehaviour
{
    public Vector3 moveLength;

    public float duration;
    // Start is called before the first frame update
    void Start()
    {
        transform.DOLocalMove(moveLength + transform.position, duration).SetLoops(-1,LoopType.Yoyo).SetEase(Ease.Linear);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        collision.transform.parent = transform;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        collision.transform.parent = null;
    }
}
