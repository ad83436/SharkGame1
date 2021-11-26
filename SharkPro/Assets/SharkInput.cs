// GENERATED AUTOMATICALLY FROM 'Assets/SharkInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @SharkInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @SharkInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""SharkInput"",
    ""maps"": [
        {
            ""name"": ""Keyboard"",
            ""id"": ""6e367342-0d70-4b83-926a-8001d1d1d74c"",
            ""actions"": [
                {
                    ""name"": ""SwimDirection"",
                    ""type"": ""Value"",
                    ""id"": ""c551beba-bbdf-476f-a26e-de9a63907f14"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SwimForward"",
                    ""type"": ""Value"",
                    ""id"": ""6394f5a2-80b4-434d-a4c4-57a42440f434"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Bite"",
                    ""type"": ""Button"",
                    ""id"": ""f5c48798-9d2b-4ec1-a456-b25814584f8d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""11a922ed-ba33-4bee-935b-bb935e76863a"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SwimDirection"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""2ee9acec-09b4-4bab-8040-b99a57c75538"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SwimDirection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""f73f7f50-74bc-45c8-9e9f-29dd63de590d"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SwimDirection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""1591340d-cb27-4066-9646-b831afc93989"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SwimDirection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""07825a37-b2c0-4ea6-8a43-97888a939c76"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SwimDirection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""0c66ca76-3773-484c-9508-c2053779d82d"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SwimForward"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""d08c6280-90d3-42c6-90cf-1a9586c93de2"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SwimForward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""a0d1063c-e7ac-4410-9820-ec81444555a5"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SwimForward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""31dbff62-7fe2-495b-ab24-92621d796757"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SwimForward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""134abca5-35bf-49a3-b4da-fb271a05feb3"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SwimForward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""66f77a22-ddc9-4fe9-97b0-19d099f7c6ef"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Bite"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Keyboard
        m_Keyboard = asset.FindActionMap("Keyboard", throwIfNotFound: true);
        m_Keyboard_SwimDirection = m_Keyboard.FindAction("SwimDirection", throwIfNotFound: true);
        m_Keyboard_SwimForward = m_Keyboard.FindAction("SwimForward", throwIfNotFound: true);
        m_Keyboard_Bite = m_Keyboard.FindAction("Bite", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // Keyboard
    private readonly InputActionMap m_Keyboard;
    private IKeyboardActions m_KeyboardActionsCallbackInterface;
    private readonly InputAction m_Keyboard_SwimDirection;
    private readonly InputAction m_Keyboard_SwimForward;
    private readonly InputAction m_Keyboard_Bite;
    public struct KeyboardActions
    {
        private @SharkInput m_Wrapper;
        public KeyboardActions(@SharkInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @SwimDirection => m_Wrapper.m_Keyboard_SwimDirection;
        public InputAction @SwimForward => m_Wrapper.m_Keyboard_SwimForward;
        public InputAction @Bite => m_Wrapper.m_Keyboard_Bite;
        public InputActionMap Get() { return m_Wrapper.m_Keyboard; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(KeyboardActions set) { return set.Get(); }
        public void SetCallbacks(IKeyboardActions instance)
        {
            if (m_Wrapper.m_KeyboardActionsCallbackInterface != null)
            {
                @SwimDirection.started -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnSwimDirection;
                @SwimDirection.performed -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnSwimDirection;
                @SwimDirection.canceled -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnSwimDirection;
                @SwimForward.started -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnSwimForward;
                @SwimForward.performed -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnSwimForward;
                @SwimForward.canceled -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnSwimForward;
                @Bite.started -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnBite;
                @Bite.performed -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnBite;
                @Bite.canceled -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnBite;
            }
            m_Wrapper.m_KeyboardActionsCallbackInterface = instance;
            if (instance != null)
            {
                @SwimDirection.started += instance.OnSwimDirection;
                @SwimDirection.performed += instance.OnSwimDirection;
                @SwimDirection.canceled += instance.OnSwimDirection;
                @SwimForward.started += instance.OnSwimForward;
                @SwimForward.performed += instance.OnSwimForward;
                @SwimForward.canceled += instance.OnSwimForward;
                @Bite.started += instance.OnBite;
                @Bite.performed += instance.OnBite;
                @Bite.canceled += instance.OnBite;
            }
        }
    }
    public KeyboardActions @Keyboard => new KeyboardActions(this);
    public interface IKeyboardActions
    {
        void OnSwimDirection(InputAction.CallbackContext context);
        void OnSwimForward(InputAction.CallbackContext context);
        void OnBite(InputAction.CallbackContext context);
    }
}
