using System.Collections;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    public GameObject RickRoll, Hand;
    private Vector3 rickPos, handPos;
    private Rigidbody rickRB;
    private bool isCoroutineExecuting = false;

    void Start()
    {
        rickRB = GetComponent<Rigidbody>();
    }

    void Update()
    {
        rickPos = RickRoll.transform.position;
 //       StartCoroutine(ExecuteAfterTime(3));
          MoveRickBack();
    }

 /*   IEnumerator ExecuteAfterTime (float time)
    {
        if (isCoroutineExecuting)
        yield break;
 
        isCoroutineExecuting = true;
        yield return new WaitForSeconds(time);
            
        handPos = Hand.transform.position;
        MoveRickBack(); 

        isCoroutineExecuting = false;
    }*/
    
    void MoveRickBack()
    {
        RickRoll.transform.position = handPos;
        rickRB.constraints = RigidbodyConstraints.FreezeRotation;
    }
}
