﻿using System.Numerics;
using System.Reflection;

namespace DirectX12GameEngine.Editor.ViewModels.Properties
{
    public class Vector2PropertyViewModel : PropertyViewModel<Vector2>
    {
        public Vector2PropertyViewModel(object model, PropertyInfo propertyInfo) : base(model, propertyInfo)
        {
        }

        public float X
        {
            get => Value.X;
            set => Set(X, value, () => Value = new Vector2(value, Y));
        }

        public float Y
        {
            get => Value.Y;
            set => Set(Y, value, () => Value = new Vector2(X, value));
        }

        protected override void OnOwnerPropertyChanged()
        {
            base.OnOwnerPropertyChanged();

            OnPropertyChanged(nameof(X));
            OnPropertyChanged(nameof(Y));
        }
    }

    public class Vector3PropertyViewModel : PropertyViewModel<Vector3>
    {
        public Vector3PropertyViewModel(object model, PropertyInfo propertyInfo) : base(model, propertyInfo)
        {
        }

        public float X
        {
            get => Value.X;
            set => Set(X, value, () => Value = new Vector3(value, Y, Z));
        }

        public float Y
        {
            get => Value.Y;
            set => Set(Y, value, () => Value = new Vector3(X, value, Z));
        }

        public float Z
        {
            get => Value.Z;
            set => Set(Z, value, () => Value = new Vector3(X, Y, value));
        }

        protected override void OnOwnerPropertyChanged()
        {
            base.OnOwnerPropertyChanged();

            OnPropertyChanged(nameof(X));
            OnPropertyChanged(nameof(Y));
            OnPropertyChanged(nameof(Z));
        }
    }

    public class Vector4PropertyViewModel : PropertyViewModel<Vector4>
    {
        public Vector4PropertyViewModel(object model, PropertyInfo propertyInfo) : base(model, propertyInfo)
        {
        }

        public float X
        {
            get => Value.X;
            set => Set(X, value, () => Value = new Vector4(value, Y, Z, W));
        }

        public float Y
        {
            get => Value.Y;
            set => Set(Y, value, () => Value = new Vector4(X, value, Z, W));
        }

        public float Z
        {
            get => Value.Z;
            set => Set(Z, value, () => Value = new Vector4(X, Y, value, W));
        }

        public float W
        {
            get => Value.W;
            set => Set(W, value, () => Value = new Vector4(X, Y, Z, value));
        }

        protected override void OnOwnerPropertyChanged()
        {
            base.OnOwnerPropertyChanged();

            OnPropertyChanged(nameof(X));
            OnPropertyChanged(nameof(Y));
            OnPropertyChanged(nameof(Z));
            OnPropertyChanged(nameof(W));
        }
    }

    public class QuaternionPropertyViewModel : PropertyViewModel<Quaternion>
    {
        public QuaternionPropertyViewModel(object model, PropertyInfo propertyInfo) : base(model, propertyInfo)
        {
        }

        public float X
        {
            get => Value.X;
            set => Set(X, value, () => Value = new Quaternion(value, Y, Z, W));
        }

        public float Y
        {
            get => Value.Y;
            set => Set(Y, value, () => Value = new Quaternion(X, value, Z, W));
        }

        public float Z
        {
            get => Value.Z;
            set => Set(Z, value, () => Value = new Quaternion(X, Y, value, W));
        }

        public float W
        {
            get => Value.W;
            set => Set(W, value, () => Value = new Quaternion(X, Y, Z, value));
        }

        protected override void OnOwnerPropertyChanged()
        {
            base.OnOwnerPropertyChanged();

            OnPropertyChanged(nameof(X));
            OnPropertyChanged(nameof(Y));
            OnPropertyChanged(nameof(Z));
            OnPropertyChanged(nameof(W));
        }
    }
}
