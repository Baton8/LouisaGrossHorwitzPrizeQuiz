using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonAnswer : MonoBehaviour
{
    public int m_type;
    public GameObject m_resultObject;
    public GameObject m_resultParent;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick(){     
        m_resultObject.SetActive(true);
        m_resultParent.SetActive(true);
    }
}
