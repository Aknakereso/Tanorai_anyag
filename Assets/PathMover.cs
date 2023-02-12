
using Unity.VisualScripting;
using UnityEngine;

public class PathMover : MonoBehaviour
{

    [SerializeField] Transform start;
    [SerializeField] Transform end;
    [SerializeField] float speed;
    [SerializeField][Range(0,1)] float startPosition;

    Transform nextTarget;

    void Start()
    {
        nextTarget = end;


    }

    void Update()
    {

        Vector3 selfPos = transform.position;
        Vector3 target = nextTarget.position;
        transform.position = Vector3.MoveTowards(selfPos, target, speed * Time.deltaTime);

        if (transform.position == target)
        {
            nextTarget = nextTarget == start ? end : start;



        }
    }



    void OnValidate()
    {



        transform.position = Vector3.Lerp(start.position,end.position,startPosition);


    }

    void OnDrawGizmos()
    {

       //Color C = Color.Lerp(Color.red,Color.green);
        
        Gizmos.color = Color.red;

        Gizmos.DrawSphere(start.position, 1);
        Gizmos.DrawSphere(end.position, 1);

        
        Gizmos.DrawLine(start.position,end.position);


        
    }







}
