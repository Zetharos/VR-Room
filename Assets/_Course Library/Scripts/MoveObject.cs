using System.Collections;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    public GameObject RickRoll, Hand;
    public Collider rickCollider;
    private Vector3 rickPos;
    private Rigidbody rickRB;
   // private bool isCoroutineExecuting = false;

  void Awake()
  {
     rickRB = gameObject.GetComponent<Rigidbody>();
  }
  void Update()
  {
    RickRoll.transform.position = Hand.transform.position;
  }
    /*IEnumerator ExecuteAfterTime (float time)
    {
        if (isCoroutineExecuting)
        yield break;
 
        isCoroutineExecuting = true;
        yield return new WaitForSeconds(time);
            
        MoveRickBack(); 

        isCoroutineExecuting = false;
    }*/
    
    public void MoveRickBack()
    {
      RickRoll.transform.SetParent(Hand.transform);
      RickRoll.transform.rotation = Quaternion.Euler(transform.rotation.x, -transform.rotation.y, transform.rotation.z);
      rickRB.constraints = RigidbodyConstraints.FreezePosition;
      rickRB.constraints = RigidbodyConstraints.FreezeRotation;
      rickCollider.isTrigger = true;
    }
}
