using wrp.core.Entity.Proform;

namespace wrp.core.Entity
{
    public class CSOSNICMSFilial : BaseFilial
    {
        public CSOSNICMS CSOSNICMS { get; set; }
        public string IDCSOSNICMS { get; set; }
        public bool Normal { get; set; }
        public bool Isento { get; set; }
        public bool Outras { get; set; }
    }
}