// GENERATED AUTOMATICALLY FROM 'Assets/Input/DefaultInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @DefaultInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @DefaultInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""DefaultInput"",
    ""maps"": [
        {
            ""name"": ""Character"",
            ""id"": ""b3f52051-64bf-45fe-802d-8ba72a4acc34"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""ff5fc4d3-cfe5-4372-98f0-e7eec70b50c8"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""View"",
                    ""type"": ""PassThrough"",
                    ""id"": ""e2cdaa6a-0613-4cf3-b215-c6165515e375"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""f17ef16f-7649-4a3a-8189-68b7eb20a29d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SwitchCharacter"",
                    ""type"": ""Button"",
                    ""id"": ""870258a1-908b-4753-afab-240685510609"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""b7581927-dc35-43ea-b887-3e0709db5aa8"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""View"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""726d46de-db4c-4cee-8508-cb5f288b0c5b"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": ""ScaleVector2(x=50,y=50)"",
                    ""groups"": """",
                    ""action"": ""View"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""7dec039a-55a0-4e51-bf88-5beee851b307"",
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
                    ""id"": ""296fa0fe-955d-4340-aeb5-c86dffe50b8b"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""b2d52b40-f8ca-4d04-a5b4-974b81d487e6"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""d88a65d3-3e7d-4acf-9f6b-1f69ab7daa45"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""77a85e12-2199-4f45-ad21-82e7b7e0b445"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""f0466fcf-0c92-40e8-b71d-e3d30d72526a"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""494485c9-ba18-41c9-ac62-eb956191b4c8"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7d694919-b13a-4f1c-9101-f59a5bcf71d1"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""94275844-74ff-46be-aaea-e611b62e214a"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SwitchCharacter"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f89d3eb7-aae6-4c6e-9890-844f9175c955"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SwitchCharacter"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Items"",
            ""id"": ""f23f2974-a9f8-44c0-a159-f512254e1ca1"",
            ""actions"": [
                {
                    ""name"": ""Equip"",
                    ""type"": ""Button"",
                    ""id"": ""7d380064-1020-4eec-973b-0eff7bfd2a41"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Use"",
                    ""type"": ""Button"",
                    ""id"": ""080d283b-3fe1-41c3-87ea-df0f4aeb7d1e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Alternative"",
                    ""type"": ""Button"",
                    ""id"": ""94e681b4-0a26-40d3-bf6b-05336d4e90e5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PrimaryWeapon"",
                    ""type"": ""Button"",
                    ""id"": ""90e92b46-3404-4bc7-8975-8a389180d1b5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SecondaryWeapon"",
                    ""type"": ""Button"",
                    ""id"": ""0218e10d-3873-43a8-978f-9600fd1442e4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Melee"",
                    ""type"": ""Button"",
                    ""id"": ""093103fb-3463-4adf-8868-f8ddcdee348e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Drop"",
                    ""type"": ""Button"",
                    ""id"": ""83da609b-4676-45a0-97a5-44995b951a46"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""d734d2d3-8ed8-4bde-b176-23897d13d27b"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Equip"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6ec5d7cf-0a48-4980-804f-3da2ae58f0ba"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Use"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e9aac905-e3d8-40e0-b54b-ccb86d077ca9"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PrimaryWeapon"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b250c66d-e211-401d-b23f-c01247b70d09"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SecondaryWeapon"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5731722a-b3a6-46c5-b08f-b91c386e3fa0"",
                    ""path"": ""<Keyboard>/3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Melee"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2bb4ab6c-7110-496d-bc2d-99cb882b0c2a"",
                    ""path"": ""<Keyboard>/g"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Drop"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c455758d-534a-426b-9424-c115e880fd8d"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Alternative"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Character
        m_Character = asset.FindActionMap("Character", throwIfNotFound: true);
        m_Character_Movement = m_Character.FindAction("Movement", throwIfNotFound: true);
        m_Character_View = m_Character.FindAction("View", throwIfNotFound: true);
        m_Character_Jump = m_Character.FindAction("Jump", throwIfNotFound: true);
        m_Character_SwitchCharacter = m_Character.FindAction("SwitchCharacter", throwIfNotFound: true);
        // Items
        m_Items = asset.FindActionMap("Items", throwIfNotFound: true);
        m_Items_Equip = m_Items.FindAction("Equip", throwIfNotFound: true);
        m_Items_Use = m_Items.FindAction("Use", throwIfNotFound: true);
        m_Items_Alternative = m_Items.FindAction("Alternative", throwIfNotFound: true);
        m_Items_PrimaryWeapon = m_Items.FindAction("PrimaryWeapon", throwIfNotFound: true);
        m_Items_SecondaryWeapon = m_Items.FindAction("SecondaryWeapon", throwIfNotFound: true);
        m_Items_Melee = m_Items.FindAction("Melee", throwIfNotFound: true);
        m_Items_Drop = m_Items.FindAction("Drop", throwIfNotFound: true);
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

    // Character
    private readonly InputActionMap m_Character;
    private ICharacterActions m_CharacterActionsCallbackInterface;
    private readonly InputAction m_Character_Movement;
    private readonly InputAction m_Character_View;
    private readonly InputAction m_Character_Jump;
    private readonly InputAction m_Character_SwitchCharacter;
    public struct CharacterActions
    {
        private @DefaultInput m_Wrapper;
        public CharacterActions(@DefaultInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Character_Movement;
        public InputAction @View => m_Wrapper.m_Character_View;
        public InputAction @Jump => m_Wrapper.m_Character_Jump;
        public InputAction @SwitchCharacter => m_Wrapper.m_Character_SwitchCharacter;
        public InputActionMap Get() { return m_Wrapper.m_Character; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CharacterActions set) { return set.Get(); }
        public void SetCallbacks(ICharacterActions instance)
        {
            if (m_Wrapper.m_CharacterActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_CharacterActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_CharacterActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_CharacterActionsCallbackInterface.OnMovement;
                @View.started -= m_Wrapper.m_CharacterActionsCallbackInterface.OnView;
                @View.performed -= m_Wrapper.m_CharacterActionsCallbackInterface.OnView;
                @View.canceled -= m_Wrapper.m_CharacterActionsCallbackInterface.OnView;
                @Jump.started -= m_Wrapper.m_CharacterActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_CharacterActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_CharacterActionsCallbackInterface.OnJump;
                @SwitchCharacter.started -= m_Wrapper.m_CharacterActionsCallbackInterface.OnSwitchCharacter;
                @SwitchCharacter.performed -= m_Wrapper.m_CharacterActionsCallbackInterface.OnSwitchCharacter;
                @SwitchCharacter.canceled -= m_Wrapper.m_CharacterActionsCallbackInterface.OnSwitchCharacter;
            }
            m_Wrapper.m_CharacterActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @View.started += instance.OnView;
                @View.performed += instance.OnView;
                @View.canceled += instance.OnView;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @SwitchCharacter.started += instance.OnSwitchCharacter;
                @SwitchCharacter.performed += instance.OnSwitchCharacter;
                @SwitchCharacter.canceled += instance.OnSwitchCharacter;
            }
        }
    }
    public CharacterActions @Character => new CharacterActions(this);

    // Items
    private readonly InputActionMap m_Items;
    private IItemsActions m_ItemsActionsCallbackInterface;
    private readonly InputAction m_Items_Equip;
    private readonly InputAction m_Items_Use;
    private readonly InputAction m_Items_Alternative;
    private readonly InputAction m_Items_PrimaryWeapon;
    private readonly InputAction m_Items_SecondaryWeapon;
    private readonly InputAction m_Items_Melee;
    private readonly InputAction m_Items_Drop;
    public struct ItemsActions
    {
        private @DefaultInput m_Wrapper;
        public ItemsActions(@DefaultInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Equip => m_Wrapper.m_Items_Equip;
        public InputAction @Use => m_Wrapper.m_Items_Use;
        public InputAction @Alternative => m_Wrapper.m_Items_Alternative;
        public InputAction @PrimaryWeapon => m_Wrapper.m_Items_PrimaryWeapon;
        public InputAction @SecondaryWeapon => m_Wrapper.m_Items_SecondaryWeapon;
        public InputAction @Melee => m_Wrapper.m_Items_Melee;
        public InputAction @Drop => m_Wrapper.m_Items_Drop;
        public InputActionMap Get() { return m_Wrapper.m_Items; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ItemsActions set) { return set.Get(); }
        public void SetCallbacks(IItemsActions instance)
        {
            if (m_Wrapper.m_ItemsActionsCallbackInterface != null)
            {
                @Equip.started -= m_Wrapper.m_ItemsActionsCallbackInterface.OnEquip;
                @Equip.performed -= m_Wrapper.m_ItemsActionsCallbackInterface.OnEquip;
                @Equip.canceled -= m_Wrapper.m_ItemsActionsCallbackInterface.OnEquip;
                @Use.started -= m_Wrapper.m_ItemsActionsCallbackInterface.OnUse;
                @Use.performed -= m_Wrapper.m_ItemsActionsCallbackInterface.OnUse;
                @Use.canceled -= m_Wrapper.m_ItemsActionsCallbackInterface.OnUse;
                @Alternative.started -= m_Wrapper.m_ItemsActionsCallbackInterface.OnAlternative;
                @Alternative.performed -= m_Wrapper.m_ItemsActionsCallbackInterface.OnAlternative;
                @Alternative.canceled -= m_Wrapper.m_ItemsActionsCallbackInterface.OnAlternative;
                @PrimaryWeapon.started -= m_Wrapper.m_ItemsActionsCallbackInterface.OnPrimaryWeapon;
                @PrimaryWeapon.performed -= m_Wrapper.m_ItemsActionsCallbackInterface.OnPrimaryWeapon;
                @PrimaryWeapon.canceled -= m_Wrapper.m_ItemsActionsCallbackInterface.OnPrimaryWeapon;
                @SecondaryWeapon.started -= m_Wrapper.m_ItemsActionsCallbackInterface.OnSecondaryWeapon;
                @SecondaryWeapon.performed -= m_Wrapper.m_ItemsActionsCallbackInterface.OnSecondaryWeapon;
                @SecondaryWeapon.canceled -= m_Wrapper.m_ItemsActionsCallbackInterface.OnSecondaryWeapon;
                @Melee.started -= m_Wrapper.m_ItemsActionsCallbackInterface.OnMelee;
                @Melee.performed -= m_Wrapper.m_ItemsActionsCallbackInterface.OnMelee;
                @Melee.canceled -= m_Wrapper.m_ItemsActionsCallbackInterface.OnMelee;
                @Drop.started -= m_Wrapper.m_ItemsActionsCallbackInterface.OnDrop;
                @Drop.performed -= m_Wrapper.m_ItemsActionsCallbackInterface.OnDrop;
                @Drop.canceled -= m_Wrapper.m_ItemsActionsCallbackInterface.OnDrop;
            }
            m_Wrapper.m_ItemsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Equip.started += instance.OnEquip;
                @Equip.performed += instance.OnEquip;
                @Equip.canceled += instance.OnEquip;
                @Use.started += instance.OnUse;
                @Use.performed += instance.OnUse;
                @Use.canceled += instance.OnUse;
                @Alternative.started += instance.OnAlternative;
                @Alternative.performed += instance.OnAlternative;
                @Alternative.canceled += instance.OnAlternative;
                @PrimaryWeapon.started += instance.OnPrimaryWeapon;
                @PrimaryWeapon.performed += instance.OnPrimaryWeapon;
                @PrimaryWeapon.canceled += instance.OnPrimaryWeapon;
                @SecondaryWeapon.started += instance.OnSecondaryWeapon;
                @SecondaryWeapon.performed += instance.OnSecondaryWeapon;
                @SecondaryWeapon.canceled += instance.OnSecondaryWeapon;
                @Melee.started += instance.OnMelee;
                @Melee.performed += instance.OnMelee;
                @Melee.canceled += instance.OnMelee;
                @Drop.started += instance.OnDrop;
                @Drop.performed += instance.OnDrop;
                @Drop.canceled += instance.OnDrop;
            }
        }
    }
    public ItemsActions @Items => new ItemsActions(this);
    public interface ICharacterActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnView(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnSwitchCharacter(InputAction.CallbackContext context);
    }
    public interface IItemsActions
    {
        void OnEquip(InputAction.CallbackContext context);
        void OnUse(InputAction.CallbackContext context);
        void OnAlternative(InputAction.CallbackContext context);
        void OnPrimaryWeapon(InputAction.CallbackContext context);
        void OnSecondaryWeapon(InputAction.CallbackContext context);
        void OnMelee(InputAction.CallbackContext context);
        void OnDrop(InputAction.CallbackContext context);
    }
}
