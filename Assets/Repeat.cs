using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Repeat : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // elõzõ órából:
        // vektorok;
        // számolás vektorokkal
        // update használata


        // hozzunk létre  vektorokat. Egy háromdimenziósat (úgy kell mint a két dimenziósat)

        Vector3 my3dVectorX = new Vector3(3,3,3); // ez a vektor a zárójelben megadott pozícióban helyezkedik el a "tér" ben. 
        Vector3 my3dVectorY = new Vector3(4,7,12);

        //csináljunk  2 dimenziós vektorokat.

        Vector2 my2dVectorX = new Vector2(23,5);
        Vector2 my2dVectorY = new Vector2(55,6);


        //ezekkel matematikai mûveleteket végezhetünk: Vector 2 vagy 2 d-s Vector 2 vagy 3d-ssel.
        //                                             Vector2 vagy 3 d-s osztása / szorzása skalárral, azaz számmal.

        // Vector2  + Vector2 -> van két koordinátája x,y x x el és y y-al lesz összeadva vagy a kivonás elvégezve.

        // pl.: my3dVectorX + my3dVectorY = 3+4; 3+7; 3+12
        // pl.: my2dVectorX - my2dVectorY = 23-55; 5-6 =x= -32; y = -1  !!! a  távolság inkább az, ha a nagyobból vonjuk ki a kisebbet

        Debug.Log(my2dVectorX - my2dVectorY);
        Debug.Log(my3dVectorX - my3dVectorY);


        // Nézzünk hosszt: 
        Vector2 my2dVectorZ = new Vector2(3,4);
        float my2dVectorZmagnitude = my2dVectorZ.magnitude;
        Debug.Log(my2dVectorZmagnitude);


        float a = 3, b = 4;
        float m = a*a + b * b;
        float f = Mathf.Sqrt(m);
        Debug.Log(f); // átfogó    f == my2dVectorZmagnitude a hossz(magnitude) = a valahonnét (de elvileg nem nullából) induló és a koordintapontba mutató vektor hosszával.

        //Ezt szokás egyenlõre szabni, hogy minden irányba ugyanakkora hosszú legyen. normalze


        Vector3 v3d = new Vector3(3,5,10);

        Vector3 v3dNorm = v3d.normalized;
        Debug.Log(v3dNorm);

        Vector3 vektorpeldaI = new Vector3(3, 5, 10); 
        Vector3 normal = vektorpeldaI.normalized;
        Debug.Log(normal);


        //Távszámítás: ehhez két vektort veszük és ezek összehasonlított értékét egy másik Vektor veszi fel
        



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
