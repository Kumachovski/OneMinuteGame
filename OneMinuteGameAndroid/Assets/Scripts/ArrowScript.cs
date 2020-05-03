using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowScript : MonoBehaviour
{
    // Start is called before the first frame update
    public enum Position{
        down = 1,
        left = 2,
        up =3,
        right = 4
    }
    public Position arrowLocation;
    void Start()
    {
        arrowLocation  = (Position) 1;
    }

    // Update is called once per frame
    void Update()
    {
        ChangePosition(arrowLocation);
    }
    private void ChangePosition(Position pos){
        switch(pos){
            case (Position)1:
                this.transform.localPosition = new Vector3(0f,-1f,0f);
                pos +=1;
                break;
            case (Position)2:
                this.transform.localPosition = new Vector3(-1f,0f,0f);
                pos +=1;
                break;
            case (Position)3:
                this.transform.localPosition = new Vector3(0f,1f,0f);
                pos +=1;
                break;
            case (Position)4:
                this.transform.localPosition = new Vector3(1f,0f,0f);
                pos +=1;
                break;
        }
        
    }
}
