using wrp.core.Entity.Proform;

namespace wrp.core.Entity
{
    public class CSTIPIFilial : BaseFilial
    {
        public CSTIPI CSTIPI { get; set; }
        public string IDCSTIPI { get; set; }
        public bool Normal { get; set; }
        public bool Isento { get; set; }
        public bool Outras { get; set; }
    }
}