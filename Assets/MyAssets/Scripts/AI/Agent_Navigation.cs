using UnityEngine;
using UnityEngine.AI;

public class Agent_Navigation : MonoBehaviour
{
    /*
       //Directe reference zolang we op hetzelfde object zitten
       //NavMeshAgent getAgent => GetComponent<NavMeshAgent>();

       //Haal de reference op en stel deze in zodra ons script voor de
       //eerste keer aan staat.
           void Start()
           {
               getAgent = GetComponent<NavMeshAgent>();
           }*/
    [SerializeField] NavMeshAgent getAgent;
    [SerializeField] Transform target;
    
    float timer = 0f;
    [SerializeField] float delay = 0.3f;
    void Update()
    {
        if (timer < delay)
        {
            timer += Time.deltaTime;
            return;
        }
        else
        {
            getAgent.SetDestination(target.position);
        }
        //if (getAgent != null) print(getAgent.name);
    }

}
