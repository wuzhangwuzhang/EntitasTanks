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
        static readonly TankComponent tankComponent = new TankComponent();

        public bool isTank {
            get { return HasComponent(ComponentIds.Tank); }
            set {
                if (value != isTank) {
                    if (value) {
                        AddComponent(ComponentIds.Tank, tankComponent);
                    } else {
                        RemoveComponent(ComponentIds.Tank);
                    }
                }
            }
        }

        public Entity IsTank(bool value) {
            isTank = value;
            return this;
        }
    }

    public partial class Matcher {
        static IMatcher _matcherTank;

        public static IMatcher Tank {
            get {
                if (_matcherTank == null) {
                    var matcher = (Matcher)Matcher.AllOf(ComponentIds.Tank);
                    matcher.componentNames = ComponentIds.componentNames;
                    _matcherTank = matcher;
                }

                return _matcherTank;
            }
        }
    }
}
