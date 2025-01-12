using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed = 1.0f;
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private GameObject _plantPrefab;
    [SerializeField] private int _numSeeds = 5; 
    [SerializeField] private PlantCountUI _plantCountUI;

    private int _numSeedsLeft;
    private int _numSeedsPlanted;

    private void Start ()
    {
        //sets variable to default to start game
        _numSeedsLeft = _numSeeds;
        //set variable to 0 defualt to start game
        _numSeedsPlanted = 0;
        //updates UI 
        _plantCountUI.UpdateSeeds(_numSeedsLeft, _numSeedsPlanted);

    }

    private void Update()
    {
        //player movement
        if (Input.GetKey(KeyCode.W))
        {
            _playerTransform.Translate(Vector3.up * _speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S))
        {
            _playerTransform.Translate(Vector3.down * _speed * Time.deltaTime);

        }
        if (Input.GetKey(KeyCode.D))
        {
            _playerTransform.Translate(Vector3.right * _speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            _playerTransform.Translate(Vector3.left * _speed * Time.deltaTime);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PlantSeed();
        }
        
    }

    public void PlantSeed ()
    {
        if(_numSeedsLeft > 0)
        {
            Instantiate(_plantPrefab , new Vector3(_playerTransform.position.x , _playerTransform.position.y , _playerTransform.position.z) , _playerTransform.rotation);
            _numSeedsLeft--;
            _numSeedsPlanted++;
            _plantCountUI.UpdateSeeds(_numSeedsLeft, _numSeedsPlanted);

            
        }
    }
}
