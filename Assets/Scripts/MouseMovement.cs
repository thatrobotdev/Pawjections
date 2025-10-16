using UnityEngine;

public class MouseMovement : MonoBehaviour
{
    [Header("Movement Settings")]
    public float moveSpeed = 3f;
    
    [Header("Audio Settings")]
    public AudioClip bounceSound;

    private Vector2 _moveDirection;
    private Camera _mainCam;
    private Vector2 _screenBounds;
    private AudioSource _audioSource;

    private void Start()
    {
        _mainCam = Camera.main;
        _audioSource = GetComponent<AudioSource>();
        SetScreenBounds();
        PickNewDirection();
    }

    private void Update()
    {
        MoveMouse();
        CheckBounds();
    }

    private void MoveMouse()
    {
        transform.Translate(_moveDirection * (moveSpeed * Time.deltaTime), Space.World);
    }

    private void CheckBounds()
    {
        Vector3 pos = transform.position;

        // If fish leaves bounds, pick a new direction
        if (pos.x > _screenBounds.x || pos.x < -_screenBounds.x ||
            pos.y > _screenBounds.y || pos.y < -_screenBounds.y)
        {
            PickNewDirection();

            // Clamp back inside
            pos.x = Mathf.Clamp(pos.x, -_screenBounds.x, _screenBounds.x);
            pos.y = Mathf.Clamp(pos.y, -_screenBounds.y, _screenBounds.y);
            transform.position = pos;

            PlayBounceSound();
        }
    }

    private void PickNewDirection()
    {
        float angle = Random.Range(0f, 360f);
        _moveDirection = new Vector2(Mathf.Cos(angle), Mathf.Sin(angle)).normalized;
    }

    private void SetScreenBounds()
    {
        // World coordinates of screen corners
        Vector3 screenTopRight = _mainCam.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));

        _screenBounds = new Vector2(screenTopRight.x - 0.5f, screenTopRight.y - 0.5f); // margin
    }
    
    private void PlayBounceSound()
    {
        if (bounceSound != null)
            _audioSource.PlayOneShot(bounceSound);
    }
}