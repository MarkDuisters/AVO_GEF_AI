using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.AI;
public class AI_Agent_WalkToPoint : MonoBehaviour
{
    [SerializeField] NavMeshAgent getAgent;
    [SerializeField] Transform targetA;
    [SerializeField] Transform targetB;
    void Start()
    {
        /*//NIET DOEN!! Dit is een infinite loop en blokkeerd je process thread.
        while (true)
        {
            print("oh fuck");
        }*/

        //Start onze coroutine. Deze draait langs de logica van ons project.
        //Hierdoor blokkeerd ons process niet en draait de game verder.
        StartCoroutine(WalkToPoint());

    }
    IEnumerator WalkToPoint()
    {

        getAgent.SetDestination(targetA.position);
        while (getAgent.pathPending)
        {
            yield return null;
        }
        //  print(getAgent.remainingDistance);
        while (getAgent.remainingDistance > 0.2f)
        {
            //  print(getAgent.remainingDistance);
            yield return null;
        }

        yield return new WaitForSeconds(5f);
        getAgent.SetDestination(targetB.position);
    }
}