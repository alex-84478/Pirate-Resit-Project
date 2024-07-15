using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestController : MonoBehaviour
{

    Animator chestAnim;

    private void OnTriggerEnter(Collider other)
    {
        chestAnim.SetBool("IsOpening", true);
    }

    // Start is called before the first frame update
    void Start()
    {
        chestAnim = this.transform.parent.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
