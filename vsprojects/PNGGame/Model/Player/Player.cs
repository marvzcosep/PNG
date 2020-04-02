using PNGGAME.Interface;

namespace PNGGAME.Model
{
    public abstract class Player : IPlayer
    {
        private string _name;

        public virtual string Name { get => this._name; set => this._name = value; }
    }
}
