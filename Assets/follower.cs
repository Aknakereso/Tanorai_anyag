
using UnityEngine;

public class follower : MonoBehaviour
{

    [SerializeField] float speed = 3;
    [SerializeField] Transform target;
    [SerializeField] float sinusAmp;
    [SerializeField] float sineFreq;

    private void Update()
    {

       // Vector3 nextPositon = Vector3.MoveTowards();



     
        Vector3 selfPosition = transform.position;
        Vector3 positionTarget = target.position;


        Vector3 direction = positionTarget - selfPosition;
        //  direction.Normalize();

        /*

        float sinus = Mathf.Sin(Time.time) * sineFreq;
        sinus *= sinusAmp;
        sinus *= 1;
        direction *= sinus;*/



        //  Vector3 velocity = direction * speed;

        //  transform.position += velocity * Time.deltaTime; ;

        transform.position = Vector3.MoveTowards(selfPosition,positionTarget,speed* Time.deltaTime);

        if(direction != Vector3.zero)
        transform.rotation = Quaternion.LookRotation(direction);






    }
}
