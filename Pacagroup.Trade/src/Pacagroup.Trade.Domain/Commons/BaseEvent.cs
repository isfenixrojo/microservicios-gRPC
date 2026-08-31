namespace Pacagroup.Trade.Domain.Commons
{
    public abstract class BaseEvent
    {
        public Guid MessageId { get; set; } //Identifica el eventos
        public DateTime PublishTime { get; set; } //Identifica la hora del eventos
    }
}
