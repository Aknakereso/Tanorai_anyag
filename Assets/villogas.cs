
using Unity.VisualScripting;
using UnityEngine;

public class villogas : MonoBehaviour
{

    [SerializeField] Light light;
    [SerializeField] Color szin1;
    [SerializeField] Color szin2;
    [SerializeField] float freq =1;



    void Update()
    {
        float t = Mathf.Sin(Time.time* (2* Mathf.PI)*freq);

        t += 1;
        t /= 2;
        Color c = Color.Lerp(szin1, szin2, t);

        light.color = c;



        
    }



}
