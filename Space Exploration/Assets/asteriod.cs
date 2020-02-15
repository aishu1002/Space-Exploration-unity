
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asteriod : MonoBehaviour
{
    Vector3 rotationAngles = new Vector3(5, 0, 0);
   public float speed = 10f;

    Vector3 scaleAnimate = new Vector3(0.1f, 0.1f, 10f);
    bool upScale = true;

    bool moveBack = true;

    void SimpleScaleAnimation()
    {
        transform.localScale += Vector3.one * Time.deltaTime;
    }

   /* void ScaleAnimate()
    {
        if (transform.localScale.x > 3)
            upScale = false;
        else if (transform.localScale.x < 1)
            upScale = true;

        if (upScale)
            transform.localScale += scaleAnimate;
        else
            transform.localScale -= scaleAnimate;
    }*/

    void SimpleTranslateAnimation()
    {
        transform.Translate(0,0,10, Space.World);
    }

    void TranslateAnimation()
    {
        if (transform.position.z > -750)
            moveBack = false;
        else if (transform.position.z <4)
            moveBack = true;

        if (moveBack)
            transform.Translate(3, 2, 10, Space.World);
        else
            transform.Translate(-2, -2.2f, 0, Space.World);
    }

    // Update is called once per frame
    void Update()
    {
        /* Few Rotate Animation Examples */
        //transform.Rotate(rotationAngles);
        //transform.Rotate(Vector3.right);
        //transform.Rotate(Vector3.right, 2.0f);
        transform.Rotate(Vector3.one, 2.0f);

        /* Scale */
        //SimpleScaleAnimation();
       // ScaleAnimate();

        /* Translate */
        //SimpleTranslateAnimation();
        TranslateAnimation();
    }
}