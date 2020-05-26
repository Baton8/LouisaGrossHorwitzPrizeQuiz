using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonResult : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject m_titleObject;
    public GameObject m_resultObject;
    public GameObject m_resultOk;
    public GameObject m_resultNg;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick(){
        m_titleObject.SetActive(true);
        m_resultObject.SetActive(false);
        m_resultOk.SetActive(false);
        m_resultNg.SetActive(false);

    }

}
