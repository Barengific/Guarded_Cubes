using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {

    public GameObject player;
    //private PlayerController playerController;

    public Button dBtn;
    public Button uBtn;
    public Button lBtn;
    public Button rBtn;

    void Start() {

        player = GameObject.Find("Cube");

        dBtn.GetComponent<Button>();
        dBtn.onClick.AddListener(DOnClick);

        uBtn.GetComponent<Button>();
        uBtn.onClick.AddListener(UOnClick);

        lBtn.GetComponent<Button>();
        lBtn.onClick.AddListener(LOnClick);

        rBtn.GetComponent<Button>();
        rBtn.onClick.AddListener(ROnClick);
    }

    void DOnClick() {
        Debug.Log("down");
        player.transform.position += Vector3.right * 100.0f * Time.deltaTime;
    }
    void UOnClick() {
        Debug.Log("up");
        player.transform.position += Vector3.left * 100.0f * Time.deltaTime;
    }
    void LOnClick() {
        Debug.Log("left");
    }
    void ROnClick() {
        Debug.Log("right");
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown("w")) {
            print("up key was pressed");
        }
        if (Input.GetKeyDown("s")) {
            print("down key was pressed");
        }
        if (Input.GetKeyDown("a")) {
            print("left key was pressed");
        }
        if (Input.GetKeyDown("d")) {
            print("right key was pressed");
        }
        if (Input.GetKeyDown("space")) {
            print("jump key was pressed");
        }

    }
}
