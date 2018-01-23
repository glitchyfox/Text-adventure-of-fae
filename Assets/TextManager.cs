using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextManager : MonoBehaviour {

    public Text text;
    public Button trueButton;
    public Button falseButton;

    public bool option 1;
    public bool option 2;

    private enum States
    {
        question, trueState, falseState
    };

    private States mystate;

}

    // Use this for initialization
    void Start () {
    myStates = States.question;
	}	

// Update is called once per frame
	void Update () {
    if (mystate == States.question) (question();)
    else if (mystate == States.truestate) {truestate();}
	else if (mystate == States.falsestate) { falsestate();}
}

    void onEnable() {
    trueButton.onClick.AddListener(delegate { Option1 = true;});
    falseButton.onClick.AddListener(delegate { Option2 = true; });

}

void question() { 
        text.text = "Ice is cold.";
    }

    if(option1 == true){myState = States.trueState;}
    else if(option2 == true){mystate = States.falseState;}
    
    }

    void trueState(){
    text.text = "correct!";
}

    void falsestate(){
    text.text = "Incorrect!";
}

}