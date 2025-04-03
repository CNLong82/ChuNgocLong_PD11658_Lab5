using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    AudioSource _do, _re, _mi, _fa, _son, _la, _si;
    void Start()
    {
        Debug.Log(message:"Start");
        _do = GameObject.FindWithTag("do").GetComponent<AudioSource>();
        _re = GameObject.FindWithTag("re").GetComponent<AudioSource>();
        _mi = GameObject.FindWithTag("mi").GetComponent<AudioSource>();
        _fa = GameObject.FindWithTag("fa").GetComponent<AudioSource>();
        _son = GameObject.FindWithTag("son").GetComponent<AudioSource>();
        _la = GameObject.FindWithTag("la").GetComponent<AudioSource>();
        _si = GameObject.FindWithTag("si").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log(message:"Press A");
            _do.Play();
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log(message: "Press S");
            _re.Play();
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log(message: "Press D");
            _mi.Play();
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            Debug.Log(message: "Press F");
            _fa.Play();
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            Debug.Log(message: "Press G");
            _son.Play();
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            Debug.Log(message: "Press H");
            _la.Play();
        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            Debug.Log(message: "Press J");
            _si.Play();
        }
        if (Input.GetKey(KeyCode.D))
        {
            Debug.Log(message: "GetKey D");
        }
    }
}
