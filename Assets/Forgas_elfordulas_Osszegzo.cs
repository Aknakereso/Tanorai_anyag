
using UnityEngine;

public class Forgas_elfordulas_Osszegzo : MonoBehaviour
{
    [SerializeField] float spin;
    [SerializeField] Transform Target;
    // Update is called once per frame
    void Update()
    {
        // Az elfordulást 'Quaternion' ban "nézzük.
        // ha van egy objektum, annak a Quaternion ját lekérhetjük,
        // Ezt átkonvertálhatjuk Vector3 á,
        // ezek után az értékeken alakíthatunk tengelyenként,

        // ? majd vissza Quaternion ba?

        /* Tovább a Quaternion mentén:
         * 
      
         */
        /*Egyik: "q4" -es
            Vector3 minta = new Vector3(10,20,1);    
            Quaternion q4 = Quaternion.AngleAxis(30,Vector3.up); // ezzel létrehoztunk egy Quaterniont, de még nem forgunk
            Vector3 mintaB = q4.ToEulerAngles();               //konvertálás mert a lenti dolog nem tûr quaternion formát
            transform.Rotate(mintaB); //  "mûködik" Vector-al, Quaternionnal NEM,
                                      // és lassan is pörög Time.deltaime nélkül
       
         */



        /* q6 os: * Quaternonba rakjuk két vektor különbségét (irányVektor lesz ez); ezt a Quaternion értéket hozzárendeljük a transform.rotation-hoz;
            Transform t = transform;
            Vector3 relativePos = t.position;
            Vector3 targetPos = Target.position;
            Vector3 iranyVektor = targetPos - relativePos;
            valami.Normalize();
            Quaternion qLookRotation = Quaternion.LookRotation(iranyVektor);  //ide akkor Vector(3) kell| nem tudom mire jó
            transform.rotation = qLookRotation; // itt quaternionnal fordítottuk el a target felé
         */



        /*    // q7-es Quaternion létrehozás: ua mint q6
            Vector3 ownPos = transform.position;

            Vector3 targetPos = Target.position;
            Vector3 elfordulas = targetPos - ownPos;
            Quaternion q7 = Quaternion.LookRotation(elfordulas); // ha a zárójelbe rakok egy vektort amihez képest szeretném az elfodulását, nem mûködik
            transform.rotation = q7; // Quaternion értéket használva fordultunk el.
           */

        // Quaternionnal rá tuduk fordulni cél objektumokra, amikre Transform (+ név)  ként utalunk serialized mezõben



    
       

    }

}


