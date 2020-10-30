namespace Zinnia.Rule
{
    using Malimbe.PropertySerializationAttribute;
    using Malimbe.XmlDocumentationAttribute;
    using UnityEngine;
    using Zinnia.Data.Collection.List;

    /// <summary>
    /// Determines whether a <see cref="GameObject"/>'s is a gun.
    /// </summary>
    public class GunRule : GameObjectRule
    {

        /// <inheritdoc />
        protected override bool Accepts(GameObject targetGameObject)
        {
            if (targetGameObject.CompareTag("Gun"))
            {
                return true;
            }
            return false;
        }
    }
}