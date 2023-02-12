
using UnityEngine;


public class teglasKockaScriptje : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        /*
        
        Debug.Log("Hello");
        Debug.Log($"Hello {name}");
        */

        Vector2 vektor1 = new Vector2(2,4);
        float x = vektor1.x;
        Debug.Log(x);   // 2

        vektor1 = vektor1 * 3;
        Debug.Log(x);

        Vector2 v2 = new Vector2(4,5);

        Vector2 additionedVector = vektor1 + v2;
        Debug.Log(additionedVector.x); // 

        v2 *= 6; //x és y érték külön szorzódik



        Vector3 vektorpeldaI = new Vector3(3,5,10);
        Vector3 nulla = Vector3.zero;
        Vector3 up = new Vector3(0,1,0);

        Vector3 forth = new Vector3(0,0,1);

        float hossz = vektorpeldaI.magnitude;

        vektorpeldaI.Normalize();
        Vector3  normal = vektorpeldaI.normalized;

        float dist = (v2 - vektor1).magnitude;
        //táv         támértéknek a hossza
        float ditII = Vector2.Distance(v2,vektor1);
    }
    void Update()
    {
        Debug.Log($"Hello {name}");

    }


}
