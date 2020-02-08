using wrp.core.Entity.Proform;

namespace wrp.core.Entity
{
    public class CSTICMSFilial : BaseFilial
    {
        public CSTICMS CSTICMS { get; set; }
        public string IDCSTICMS { get; set; }
        public bool Normal { get; set; }
        public bool Isento { get; set; }
        public bool Outras { get; set; }
    }
}