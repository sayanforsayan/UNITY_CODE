using UnityEngine;
using DG.Tweening;
internal class PlayerOneController : ExperimentEvent
{
    private GameObject player1;
    private ExperimentCallBack callBack;

    public PlayerOneController(GameObject player1, ExperimentCallBack callBack)
    {
        this.player1 = player1;
        this.callBack = callBack;
    }


    //------------------------------------------ SUBSCRIBE & UN-SUBSCRIBE --------------------------------->>

    public void AddListner()
    {
        ExperimentCallBack.P1_Right += MoveRight;
        ExperimentCallBack.P1_Left += MoveLeft;
        ExperimentCallBack.P1_Down += MoveDown;
        ExperimentCallBack.P1_Up += MoveUp;

    }

    public void RemoveListner()
    {

        ExperimentCallBack.P1_Right -= MoveRight;
        ExperimentCallBack.P1_Left -= MoveLeft;
        ExperimentCallBack.P1_Down -= MoveDown;
        ExperimentCallBack.P1_Up -= MoveUp;
    }

    //----------------------------------------------------- FUNCTIONALITY ----------------------------------->>
    private void MoveRight()
    {
        player1.transform.DOLocalMoveX(3.5f,1f);
    }
    private void MoveLeft()
    {
        player1.transform.DOLocalMoveX(-3.5f,1f);
    }
    private void MoveDown()
    {
        player1.transform.DOLocalMoveY(-1f,1f);
    }
    private void MoveUp()
    {

        player1.transform.DOLocalMoveY(2f, 1f);
    }
}