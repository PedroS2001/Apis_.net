namespace MyFirstBackend.Models.DataModels
{
    public enum ELevel
    {
        Basico,
        Intermedio,
        Avanzado
    }
    public class Curso : BaseEntity
    {
        public string Nombre { get; set; } = string.Empty;
        public string ShortDescription { get; set; } = string.Empty;
        public string LongDescription { get; set; } = string.Empty;
        public string TargetAudience { get; set; } = string.Empty;
        public string Goals { get; set; } = string.Empty;
        public string Requirements { get; set; } = string.Empty;
        public ELevel Level { get; set; } = ELevel.Basico;
    }
}
