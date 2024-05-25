using System.Collections.Generic;
using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class ExperimentManager : MonoBehaviour
{
    public Button startBTN;
    public GameObject player1;
    public GameObject player2;
    public GameObject player3;
    public GameObject player4;


    private ExperimentCallBack callBack;
    private PlayerOneController plyrONE;
    private PlayerTwoController plyrTWO;
    private PlayerThreeController plyrTHREE;
    private PlayerFourController plyrFOUR;
    private ExprBTNController btnController;

    private void Awake()
    {
       callBack = new ExperimentCallBack();
       plyrONE = new PlayerOneController(player1,callBack);
       plyrTWO = new PlayerTwoController(player2,callBack);
       plyrTHREE = new PlayerThreeController(player3,callBack);
       plyrFOUR = new PlayerFourController(player4,callBack);
       btnController = new ExprBTNController(startBTN,callBack);
    }

    private void OnEnable()
    {
        plyrONE.AddListner();
        plyrTWO.AddListner();
        plyrTHREE.AddListner();
        plyrFOUR.AddListner();
        btnController.AddListner();
    }

    private void OnDisable()
    {
        plyrONE.RemoveListner();
        plyrTWO.RemoveListner();
        plyrTHREE.RemoveListner();
        plyrFOUR.RemoveListner();
        btnController.RemoveListner();
    }
}
