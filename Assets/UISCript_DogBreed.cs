using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UISCript_DogBreed : MonoBehaviour
{
    //Content
    public TextMeshProUGUI pageCountText;
    public Button previousButton,  nextButton;
    //API_Content
    public Transform textContainer; //Canvas Position
    public GameObject textPrefab; //para sa text
    public const float spaceInText = 2f; //space pag nag show ang text
    //Camera
    public Camera cam;
    public const float camMoveSpeed = 10f;
    //pages
    private List<string> allTexts = new List<string>();
    private int contentPerPage = 10, currentPage = 10, totalPages = 0;
    
    string URL = "https://dog.ceo/api/breeds/list/all";

    void Start()
    {
        //on click previoosu btn
        //on clicks nex tbtn
        
        //once click fetch aopi
    }
    
    //No of api when called, Ienumarator try ko
    IEnumerator FetchAPI()
    {
        //return when null
        yield return null;
    }
    
    //isntatiate page
    private void InstantiatePage()
    {
        GameObject page = Instantiate(textPrefab, textContainer);
    }
    //NextPage()
    //PreviousPage()
    //Count Clicked, CurrentPage()
    //camera jumps to next or previous page, MoveCamToPage(int numPage)
    

    

}
