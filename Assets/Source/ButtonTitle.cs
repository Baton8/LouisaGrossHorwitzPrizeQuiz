using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonTitle : MonoBehaviour
{
    public GameObject m_titleObject ;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void OnClick(){     
        Debug.Log("title");
        m_titleObject.SetActive(false);
    }
}
