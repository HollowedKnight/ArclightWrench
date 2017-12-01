using Entitas;
using UnityEngine;

public class MouseInputSystem : IInitializeSystem, IExecuteSystem
{
    private readonly InputContext _context;

    private InputEntity _leftMouseEntity;
    private InputEntity _rightMouseEntity;

    public MouseInputSystem(Contexts contexts)
    {
        _context = contexts.input;
    }

    public void Initialize()
    {
        _context.isRightMouse = true;
        _context.isLeftMouse = true;

        _leftMouseEntity = _context.leftMouseEntity;
        _rightMouseEntity = _context.rightMouseEntity;
    }

    public void Execute()
    {
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if (Input.GetMouseButtonDown(0))
        {
            _leftMouseEntity.ReplaceMouseDown(mousePosition);
        }
    }
}