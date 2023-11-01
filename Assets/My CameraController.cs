using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCameraController : MonoBehaviour
{
    private GameObject mainChara;


    // Start is called before the first frame update
    void Start()
    {
        this.mainChara = GameObject.Find("mainChara");
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector3(this.mainChara.transform.position.x, this.mainChara.transform.position.y , -20);
    }
}
