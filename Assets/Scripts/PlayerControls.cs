//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.2.0
//     from Assets/Scripts/PlayerControls.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @PlayerControls : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""Body"",
            ""id"": ""6ebecaae-fae5-46af-aca5-eec83d86fda5"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""6d1d7773-51b8-4758-976b-7402d3795406"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""8b7f9539-29f1-4b08-b043-a7dee82abded"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""CastSpell"",
                    ""type"": ""Button"",
                    ""id"": ""ad911260-e6d2-4320-848a-8625b2d396a0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""1133dcfb-23db-45c3-8551-67610b4296c2"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard_Body"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4833d896-bd82-4b6e-81df-55a605bcba5e"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad_Body"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""ec294f31-fa48-4757-9da7-f4815753bfde"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""49a277f2-6354-4a77-8a0b-690edd9c4dc4"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard_Body"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""83bb6206-799d-42d4-9062-c99f2de4ae86"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard_Body"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""c088f804-27ed-4d95-9036-c4f8a65c99c8"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard_Body"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""d4fa87ee-ddce-443d-881c-b617b0a20e00"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard_Body"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""ddc9f9dc-6a8c-41b2-bece-1cf691c41cbb"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad_Body"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2562d788-7597-4e89-ad55-dc3b5bb7c031"",
                    ""path"": ""<Keyboard>/k"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard_Body"",
                    ""action"": ""CastSpell"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Soul"",
            ""id"": ""38eda566-a308-4e2d-b235-9252a73d6848"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""22fc0dd1-1214-4636-9397-3738f6b9ddc0"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Possess"",
                    ""type"": ""Button"",
                    ""id"": ""63f996e3-80fb-4755-8a04-32aea3234a93"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Unpossess"",
                    ""type"": ""Button"",
                    ""id"": ""f1ac8d65-45eb-40fb-9d59-8a6983bde258"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Dash"",
                    ""type"": ""Button"",
                    ""id"": ""d5e08ed8-ce11-4f65-9eea-a3f449f2d753"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""ArrowKeys"",
                    ""id"": ""b6235e6e-9300-46db-9e4f-fabc9887138f"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""ec798f2d-68bb-48bc-914d-25de4e56d5b6"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard_Soul"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""1fc01012-37fd-44c9-8add-01f6a048be7b"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard_Soul"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""8954cb07-5787-403c-8cf0-8ffb30bbef06"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard_Soul"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""741fc31b-d09a-4aca-a1f9-b5bbb8786ac7"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard_Soul"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""0f21b758-4a01-4698-87ca-e40e33be4765"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad_Soul"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0a9ae59c-98c3-4f64-b234-9d3e317dcd8d"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad_Soul"",
                    ""action"": ""Possess"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dde86d77-12e3-48f9-a7b0-a4b967d839d2"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad_Soul"",
                    ""action"": ""Unpossess"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ee445392-7a79-4464-9033-b63a862d9f6f"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad_Soul"",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Menu"",
            ""id"": ""e179be15-3429-4ea5-84f1-9647e486657d"",
            ""actions"": [
                {
                    ""name"": ""Select"",
                    ""type"": ""Button"",
                    ""id"": ""fcb6f365-a75b-41bb-93a2-b3a924431e80"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""HighlightUp"",
                    ""type"": ""Button"",
                    ""id"": ""62a750f2-5f44-4eaf-988c-2b3415f8508e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""HighlightDown"",
                    ""type"": ""Button"",
                    ""id"": ""6437ab37-13fd-4048-821e-c42b6de566c8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""bd7b1c0c-c268-4172-a819-fd0ca2c3ca0d"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""58cd3375-d303-44f7-98a9-df5b932a7f3e"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cf29e535-4caf-4fa8-a980-a31d59fab913"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HighlightUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""beee5546-1009-4784-b237-d22e7716cf4a"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HighlightUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""eb4bdc8e-50fb-480c-83e9-dd5c473c8262"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HighlightUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""253e654f-434a-4068-8d90-00b289ba9dce"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HighlightDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fd0e9050-aab8-4745-85da-27f2d7b541e8"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HighlightDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bc5dde5f-e0a1-4ccf-b0fc-2ee0a213f3be"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HighlightDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Dialogue"",
            ""id"": ""826c1987-7b97-4371-911b-343efb3a1f8a"",
            ""actions"": [
                {
                    ""name"": ""NextDialogue"",
                    ""type"": ""Button"",
                    ""id"": ""7fabc94d-8595-429c-af5a-bddcd3734b9f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""119576ee-bffa-4c84-a150-aa2d8c4d6f61"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""NextDialogue"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d955053f-5f81-4c60-97ed-483836012c8c"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""NextDialogue"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""faec0a31-30a0-4baa-8484-3fdb6ac94fba"",
                    ""path"": ""<Keyboard>/anyKey"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""NextDialogue"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard_Body"",
            ""bindingGroup"": ""Keyboard_Body"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Gamepad_Body"",
            ""bindingGroup"": ""Gamepad_Body"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Keyboard_Soul"",
            ""bindingGroup"": ""Keyboard_Soul"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Gamepad_Soul"",
            ""bindingGroup"": ""Gamepad_Soul"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Body
        m_Body = asset.FindActionMap("Body", throwIfNotFound: true);
        m_Body_Movement = m_Body.FindAction("Movement", throwIfNotFound: true);
        m_Body_Jump = m_Body.FindAction("Jump", throwIfNotFound: true);
        m_Body_CastSpell = m_Body.FindAction("CastSpell", throwIfNotFound: true);
        // Soul
        m_Soul = asset.FindActionMap("Soul", throwIfNotFound: true);
        m_Soul_Movement = m_Soul.FindAction("Movement", throwIfNotFound: true);
        m_Soul_Possess = m_Soul.FindAction("Possess", throwIfNotFound: true);
        m_Soul_Unpossess = m_Soul.FindAction("Unpossess", throwIfNotFound: true);
        m_Soul_Dash = m_Soul.FindAction("Dash", throwIfNotFound: true);
        // Menu
        m_Menu = asset.FindActionMap("Menu", throwIfNotFound: true);
        m_Menu_Select = m_Menu.FindAction("Select", throwIfNotFound: true);
        m_Menu_HighlightUp = m_Menu.FindAction("HighlightUp", throwIfNotFound: true);
        m_Menu_HighlightDown = m_Menu.FindAction("HighlightDown", throwIfNotFound: true);
        // Dialogue
        m_Dialogue = asset.FindActionMap("Dialogue", throwIfNotFound: true);
        m_Dialogue_NextDialogue = m_Dialogue.FindAction("NextDialogue", throwIfNotFound: true);
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
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Body
    private readonly InputActionMap m_Body;
    private IBodyActions m_BodyActionsCallbackInterface;
    private readonly InputAction m_Body_Movement;
    private readonly InputAction m_Body_Jump;
    private readonly InputAction m_Body_CastSpell;
    public struct BodyActions
    {
        private @PlayerControls m_Wrapper;
        public BodyActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Body_Movement;
        public InputAction @Jump => m_Wrapper.m_Body_Jump;
        public InputAction @CastSpell => m_Wrapper.m_Body_CastSpell;
        public InputActionMap Get() { return m_Wrapper.m_Body; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(BodyActions set) { return set.Get(); }
        public void SetCallbacks(IBodyActions instance)
        {
            if (m_Wrapper.m_BodyActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_BodyActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_BodyActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_BodyActionsCallbackInterface.OnMovement;
                @Jump.started -= m_Wrapper.m_BodyActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_BodyActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_BodyActionsCallbackInterface.OnJump;
                @CastSpell.started -= m_Wrapper.m_BodyActionsCallbackInterface.OnCastSpell;
                @CastSpell.performed -= m_Wrapper.m_BodyActionsCallbackInterface.OnCastSpell;
                @CastSpell.canceled -= m_Wrapper.m_BodyActionsCallbackInterface.OnCastSpell;
            }
            m_Wrapper.m_BodyActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @CastSpell.started += instance.OnCastSpell;
                @CastSpell.performed += instance.OnCastSpell;
                @CastSpell.canceled += instance.OnCastSpell;
            }
        }
    }
    public BodyActions @Body => new BodyActions(this);

    // Soul
    private readonly InputActionMap m_Soul;
    private ISoulActions m_SoulActionsCallbackInterface;
    private readonly InputAction m_Soul_Movement;
    private readonly InputAction m_Soul_Possess;
    private readonly InputAction m_Soul_Unpossess;
    private readonly InputAction m_Soul_Dash;
    public struct SoulActions
    {
        private @PlayerControls m_Wrapper;
        public SoulActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Soul_Movement;
        public InputAction @Possess => m_Wrapper.m_Soul_Possess;
        public InputAction @Unpossess => m_Wrapper.m_Soul_Unpossess;
        public InputAction @Dash => m_Wrapper.m_Soul_Dash;
        public InputActionMap Get() { return m_Wrapper.m_Soul; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(SoulActions set) { return set.Get(); }
        public void SetCallbacks(ISoulActions instance)
        {
            if (m_Wrapper.m_SoulActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_SoulActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_SoulActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_SoulActionsCallbackInterface.OnMovement;
                @Possess.started -= m_Wrapper.m_SoulActionsCallbackInterface.OnPossess;
                @Possess.performed -= m_Wrapper.m_SoulActionsCallbackInterface.OnPossess;
                @Possess.canceled -= m_Wrapper.m_SoulActionsCallbackInterface.OnPossess;
                @Unpossess.started -= m_Wrapper.m_SoulActionsCallbackInterface.OnUnpossess;
                @Unpossess.performed -= m_Wrapper.m_SoulActionsCallbackInterface.OnUnpossess;
                @Unpossess.canceled -= m_Wrapper.m_SoulActionsCallbackInterface.OnUnpossess;
                @Dash.started -= m_Wrapper.m_SoulActionsCallbackInterface.OnDash;
                @Dash.performed -= m_Wrapper.m_SoulActionsCallbackInterface.OnDash;
                @Dash.canceled -= m_Wrapper.m_SoulActionsCallbackInterface.OnDash;
            }
            m_Wrapper.m_SoulActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Possess.started += instance.OnPossess;
                @Possess.performed += instance.OnPossess;
                @Possess.canceled += instance.OnPossess;
                @Unpossess.started += instance.OnUnpossess;
                @Unpossess.performed += instance.OnUnpossess;
                @Unpossess.canceled += instance.OnUnpossess;
                @Dash.started += instance.OnDash;
                @Dash.performed += instance.OnDash;
                @Dash.canceled += instance.OnDash;
            }
        }
    }
    public SoulActions @Soul => new SoulActions(this);

    // Menu
    private readonly InputActionMap m_Menu;
    private IMenuActions m_MenuActionsCallbackInterface;
    private readonly InputAction m_Menu_Select;
    private readonly InputAction m_Menu_HighlightUp;
    private readonly InputAction m_Menu_HighlightDown;
    public struct MenuActions
    {
        private @PlayerControls m_Wrapper;
        public MenuActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Select => m_Wrapper.m_Menu_Select;
        public InputAction @HighlightUp => m_Wrapper.m_Menu_HighlightUp;
        public InputAction @HighlightDown => m_Wrapper.m_Menu_HighlightDown;
        public InputActionMap Get() { return m_Wrapper.m_Menu; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MenuActions set) { return set.Get(); }
        public void SetCallbacks(IMenuActions instance)
        {
            if (m_Wrapper.m_MenuActionsCallbackInterface != null)
            {
                @Select.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnSelect;
                @Select.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnSelect;
                @Select.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnSelect;
                @HighlightUp.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnHighlightUp;
                @HighlightUp.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnHighlightUp;
                @HighlightUp.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnHighlightUp;
                @HighlightDown.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnHighlightDown;
                @HighlightDown.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnHighlightDown;
                @HighlightDown.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnHighlightDown;
            }
            m_Wrapper.m_MenuActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Select.started += instance.OnSelect;
                @Select.performed += instance.OnSelect;
                @Select.canceled += instance.OnSelect;
                @HighlightUp.started += instance.OnHighlightUp;
                @HighlightUp.performed += instance.OnHighlightUp;
                @HighlightUp.canceled += instance.OnHighlightUp;
                @HighlightDown.started += instance.OnHighlightDown;
                @HighlightDown.performed += instance.OnHighlightDown;
                @HighlightDown.canceled += instance.OnHighlightDown;
            }
        }
    }
    public MenuActions @Menu => new MenuActions(this);

    // Dialogue
    private readonly InputActionMap m_Dialogue;
    private IDialogueActions m_DialogueActionsCallbackInterface;
    private readonly InputAction m_Dialogue_NextDialogue;
    public struct DialogueActions
    {
        private @PlayerControls m_Wrapper;
        public DialogueActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @NextDialogue => m_Wrapper.m_Dialogue_NextDialogue;
        public InputActionMap Get() { return m_Wrapper.m_Dialogue; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DialogueActions set) { return set.Get(); }
        public void SetCallbacks(IDialogueActions instance)
        {
            if (m_Wrapper.m_DialogueActionsCallbackInterface != null)
            {
                @NextDialogue.started -= m_Wrapper.m_DialogueActionsCallbackInterface.OnNextDialogue;
                @NextDialogue.performed -= m_Wrapper.m_DialogueActionsCallbackInterface.OnNextDialogue;
                @NextDialogue.canceled -= m_Wrapper.m_DialogueActionsCallbackInterface.OnNextDialogue;
            }
            m_Wrapper.m_DialogueActionsCallbackInterface = instance;
            if (instance != null)
            {
                @NextDialogue.started += instance.OnNextDialogue;
                @NextDialogue.performed += instance.OnNextDialogue;
                @NextDialogue.canceled += instance.OnNextDialogue;
            }
        }
    }
    public DialogueActions @Dialogue => new DialogueActions(this);
    private int m_Keyboard_BodySchemeIndex = -1;
    public InputControlScheme Keyboard_BodyScheme
    {
        get
        {
            if (m_Keyboard_BodySchemeIndex == -1) m_Keyboard_BodySchemeIndex = asset.FindControlSchemeIndex("Keyboard_Body");
            return asset.controlSchemes[m_Keyboard_BodySchemeIndex];
        }
    }
    private int m_Gamepad_BodySchemeIndex = -1;
    public InputControlScheme Gamepad_BodyScheme
    {
        get
        {
            if (m_Gamepad_BodySchemeIndex == -1) m_Gamepad_BodySchemeIndex = asset.FindControlSchemeIndex("Gamepad_Body");
            return asset.controlSchemes[m_Gamepad_BodySchemeIndex];
        }
    }
    private int m_Keyboard_SoulSchemeIndex = -1;
    public InputControlScheme Keyboard_SoulScheme
    {
        get
        {
            if (m_Keyboard_SoulSchemeIndex == -1) m_Keyboard_SoulSchemeIndex = asset.FindControlSchemeIndex("Keyboard_Soul");
            return asset.controlSchemes[m_Keyboard_SoulSchemeIndex];
        }
    }
    private int m_Gamepad_SoulSchemeIndex = -1;
    public InputControlScheme Gamepad_SoulScheme
    {
        get
        {
            if (m_Gamepad_SoulSchemeIndex == -1) m_Gamepad_SoulSchemeIndex = asset.FindControlSchemeIndex("Gamepad_Soul");
            return asset.controlSchemes[m_Gamepad_SoulSchemeIndex];
        }
    }
    public interface IBodyActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnCastSpell(InputAction.CallbackContext context);
    }
    public interface ISoulActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnPossess(InputAction.CallbackContext context);
        void OnUnpossess(InputAction.CallbackContext context);
        void OnDash(InputAction.CallbackContext context);
    }
    public interface IMenuActions
    {
        void OnSelect(InputAction.CallbackContext context);
        void OnHighlightUp(InputAction.CallbackContext context);
        void OnHighlightDown(InputAction.CallbackContext context);
    }
    public interface IDialogueActions
    {
        void OnNextDialogue(InputAction.CallbackContext context);
    }
}