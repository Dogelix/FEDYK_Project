using UnityEngine;
using UnityEngine.UI;

/*
 * Author - Jake Yeatman
 * Date Created - 28/02/2018
 * Copyright - FEDYK : Games 2018
 */

public class RandomBGMenuImage : MonoBehaviour
{
    [SerializeField]
    private Sprite[] _bgImages;

    private int _sizeOfBGImages;
    private Image _bgImageDisplay;

    private void Start()
    {
        //_bgImages = Resources.LoadAll("Images");
        _sizeOfBGImages = _bgImages.Length;
        _bgImageDisplay = gameObject.GetComponent<Image>();

        _bgImageDisplay.sprite = _bgImages[Random.Range(0, _sizeOfBGImages)];
        
    }
}
