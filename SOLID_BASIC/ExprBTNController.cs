using UnityEngine.UI;
using UnityEngine;
internal class ExprBTNController : ExperimentEvent
{
    private Button startBTN;
    private int count = 0;

    private ExperimentCallBack callBack;

    public ExprBTNController(Button startBTN, ExperimentCallBack callBack)
    {
        this.startBTN = startBTN;
        this.callBack = callBack;
    }

    //------------------------------------------ SUBSCRIBE & UN-SUBSCRIBE --------------------------------->>

    public void AddListner()
    {
        startBTN.onClick.AddListener(PressAccept);
    }

    public void RemoveListner()
    {

    }

    //------------------------------------------------------------------------------------------------------>>
    private void PressAccept()
    {
        count++;
        switch (count)
        {
            case 1:
                callBack.RoundOne();
                break;
            case 2:
                callBack.RoundTwo();
                break;
            case 3:
                callBack.RoundThree();
                break;
            case 4:
                callBack.RoundFour();
                count = 0;
                break;
        }
    }
}