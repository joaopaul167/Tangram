using UnityEngine;
using System.Collections;


public class checkFigure : MonoBehaviour
{
    // detects when the other transform is closer than closeDistance
    // this is faster than using Vector3.magnitude
    public Transform other;
    public float closeDistance = 5.0f;
    
    private Vector2 offset;
    private float sqrLen;
    Vector2[] vertices;
    Vector2[] verticesC;
    void Update()
    {
        if (other)
        {
            offset = other.position - transform.position;
            sqrLen = offset.sqrMagnitude;

            for (int i = 0; i <= 3; i++)
            {
                switch (i)
                {
                    case 0: vertices[i] = new Vector2(other.position.x+20,other.position.y+20) ;
                            verticesC[i] = new Vector2(transform.position.x+20,transform.position.y+20) ;
                        break;
                    case 1: vertices[i] = new Vector2(other.position.x-20,other.position.y-20) ;
                            verticesC[i] = new Vector2(transform.position.x-20,transform.position.y-20) ;
                        break;
                    case 2: vertices[i] = new Vector2(other.position.x-20,other.position.y+20) ;
                            verticesC[i] = new Vector2(transform.position.x-20,transform.position.y+20) ;
                        break;
                    case 3: vertices[i] = new Vector2(other.position.x+20,other.position.y-20) ;
                            verticesC[i] = new Vector2(transform.position.x+20,transform.position.y-20) ;
                        break;
                    default:break;
                
                }
                Debug.Log("vertice x:"+vertices[i].x +" y: "+vertices[i].y);
                Debug.Log("vertice Cx:"+verticesC[i].x +" y: "+verticesC[i].y);
            }
            
            Debug.Log("centro:" + other.position);
            
            Debug.Log("centro C:" + transform.position);

            // square the distance we compare with
            if (sqrLen < closeDistance)
            {
                CheckMatch();
            }
        }
    }

    void CheckMatch(){
        Debug.Log("Close;");
    }
    
}
