//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.ComponentExtensionsGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace Entitas {
    public partial class Entity {
        public WaitComponent wait { get { return (WaitComponent)GetComponent(ComponentIds.Wait); } }

        public bool hasWait { get { return HasComponent(ComponentIds.Wait); } }

        public Entity AddWait(float newValue) {
            var component = CreateComponent<WaitComponent>(ComponentIds.Wait);
            component.value = newValue;
            return AddComponent(ComponentIds.Wait, component);
        }

        public Entity ReplaceWait(float newValue) {
            var component = CreateComponent<WaitComponent>(ComponentIds.Wait);
            component.value = newValue;
            ReplaceComponent(ComponentIds.Wait, component);
            return this;
        }

        public Entity RemoveWait() {
            return RemoveComponent(ComponentIds.Wait);
        }
    }

    public partial class Matcher {
        static IMatcher _matcherWait;

        public static IMatcher Wait {
            get {
                if (_matcherWait == null) {
                    var matcher = (Matcher)Matcher.AllOf(ComponentIds.Wait);
                    matcher.componentNames = ComponentIds.componentNames;
                    _matcherWait = matcher;
                }

                return _matcherWait;
            }
        }
    }
}