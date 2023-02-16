
using UnityEngine;

public class mySpinnerComplete : MonoBehaviour
{
    
    [SerializeField] bool lookAt;
    [SerializeField] Transform target;
    [SerializeField] float speedUp;
   

    // Update is called once per frame
    void Update()
    {
        //ezek fordul�sok az Y tengely ment�n
        bool jobbraFordulas = Input.GetKey(KeyCode.D);  
        bool balraFordulas = Input.GetKey(KeyCode.A);
        float y = 0;

        if (jobbraFordulas)
        {
            y++;
        }
        if (balraFordulas)
        {
            y--;
        }

        Vector3 r = new Vector3(0,y,0);
        //iranyitas:
        bool elore = Input.GetKey(KeyCode.UpArrow);
        bool hatra = Input.GetKey(KeyCode.DownArrow);
        bool jobbra = Input.GetKey(KeyCode.RightArrow);
        bool balra = Input.GetKey(KeyCode.LeftArrow);

        float Z = 0;
        float X = 0;

        if (elore)
        { Z++; }
        if (hatra)
        { Z--; }
        if (jobbra)
        { X++; }
        if (balra)
        { X--; }



        Vector3 direction = new Vector3(X,0,Z);
        direction.Normalize();

        Transform t = transform;

 /*
        Vector3 positionChange = t.position;
        positionChange += direction * speedUp * Time.deltaTime;
        t.position = positionChange;


        Quaternion fordulas = t.rotation;
        fordulas = Quaternion.LookRotation(direction);
        t.rotation = fordulas;
*/


        transform.Rotate(direction * 90 * Time.deltaTime);  // vagy r

        // ezek az alkot�elemei egy ir�nyvektornak, amerre n�zzen az objektumunk
        if (lookAt)
        {  
            Vector3 euler = transform.position;
            Vector3 lookAT = target.position;
            Vector3 facing = lookAT - euler;

            Quaternion qTurn = Quaternion.LookRotation(facing);
            transform.rotation = qTurn;
        } 
        
        /*
            Vector3 gerebje = new Vector3(0,y,0);  // beviszem az y �rt�k�t feleslegesen, hogy visszavihessem floatba.
            Quaternion gInQuat = Quaternion.Euler(gerebje);
            float Y = gInQuat.eulerAngles.y;*/
 
          


        
        

    }
}
